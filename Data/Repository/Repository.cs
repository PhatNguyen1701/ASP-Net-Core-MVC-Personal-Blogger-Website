using Bloger_Project_Practise.Helpers;
using Bloger_Project_Practise.Models;
using Bloger_Project_Practise.Models.Commments;
using Bloger_Project_Practise.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloger_Project_Practise.Data.Repository
{
    //Repository thu gọn các chức năng mà bạn không muốn để lộ ra ngoài => chỉ cho phép
    //user sử dụng các chức năng mà bạn muốn
    public class Repository : IRepository
    {
        private AppDbContext _ctx;

        public Repository(AppDbContext ctx)
        {
            _ctx = ctx;
        }
        public void AddPost(Post post)
        {
            _ctx.Posts.Add(post);
        }

        public List<Post> GetAllPosts()
        {
            return _ctx.Posts.ToList();
        }
        
        public IndexViewModel GetAllPosts(int pageNumber, string category, string search)
        {
            //Lập trình hàm chức năng mà c# hỗ trợ thay vì tạo biến ta có thể dùng cách này để tái sử dụng đc hàm này
            Func<Post, bool> InCategory = (post) => { return post.Category.ToLower().Equals(category.ToLower()); };

            //Cơ sở để chia trang chính là dùng 2 pt Take (lấy bao nhiêu phần tử) và Skip(bỏ qua bn pt)
            //Trừ 1 pageNumber tại Skip vì khi ta ở trang 1, 5 * 1 = 5 thì sẽ skip cả 5 ngay từ trang 1
            //Cho nên sau khi trừ 1 = 0 => có thể lấy toan bộ nội dung trang 1
            int pageSize = 3;
            //Thiết lập pageCount để đếm số post hiện tại
            int skipAmount = pageSize * (pageNumber - 1);

            //Tạo câu query lấy post theo giới hạn trang đã khai báo (3)
            //Khi làm việc với các ds lớn, các câu truy vấn sẽ dùng rất nhiều tài nguyên
            //Nếu ta lấy data từ csdl mà ko cần phải update (hoặc thay đổi gì đó tại csdl, vd chức năng search)
            //Ta nên sử AsnoTracking() cho câu truy vấn đó, EF sẽ ko theo dõi để biết kết quả của câu truy vấn này
            //Củng như ko thực hiện tác vụ nào liên quan tới thay đổi data tại csdl
            //Giúp tăng đáng kể hiệu năng của chương trình
            var query = _ctx.Posts.AsNoTracking().AsQueryable();
            //Câu lệnh dưới đây sẽ thay đổi giá trị default của Tracker EF thành no tracking
            //Sử dụng nó nếu ta muốn câu lệnh query ở trên no tracking ở mọi bối cảnh
            //_ctx.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            
            //Ta kiểm tra nếu category trống hay ko, nếu pt lấy all post có category là tham số
            //Ta hiển thị post theo category đó
            if(!String.IsNullOrEmpty(category))
            {
                //Tại net 3. ta ko còn sử dụng client side evaluation cho nên ko sử dụng đc câu lệnh dưới
                //query = query.Where(x => InCategory(x));

                //Ta phải dùng cú pháp sau
                //(09/01/2024) Vẫn lỗi...
                //(29/01/2024) Đã sửa được lỗi bằng cách ko dùng tham số thứ 2 StringComparison.InvariantCultureIgnoreCase
                query = query.Where(x => x.Category.Equals(category));
            }

            if(!String.IsNullOrEmpty(search))
            {
                //query = query.Where(x => x.Title.Contains(search)
                //|| x.Body.Contains(search)
                //|| x.Description.Contains(search));

                //Sử dụng function LIKE giúp cải tiến hiệu quả hơn so với Contains
                query = query.Where(x => EF.Functions.Like(x.Title, $"%{search}%")
                || EF.Functions.Like(x.Body, $"%{search}%") 
                || EF.Functions.Like(x.Description, $"%{search}%"));
            }

            int postCount = query.Count();
            int pageCount = (int)Math.Ceiling((double)postCount / pageSize);

            return new IndexViewModel
            {
                PageNumber = pageNumber,
                //NextPage kiểm tra nếu tổng số post lớn hơn số post bị đẩy sang trang kế hay ko
                //Nếu lớn hơn chứng tỏ vẫn còn post -> cho next page
                //Thiết lập thuộc tính pagecount để làm số trang
                //Ta cần làm tròn chữ số sau khi chia nếu ko sẽ bị thiếu trang cuối
                PageCount = pageCount,
                NextPage = postCount > skipAmount + pageSize,
                Pages = PageHelper.PageNumbers(pageNumber, pageCount).ToList(),//ta có 1 vòng lặp nữa ở _BlogPagination
                //Bằng việc chuyển pt này về ds, ta tránh đc 1 lần lặp ko cần thiết
                Category = category,
                Search = search,
                Posts = query   
                    .Skip(skipAmount)
                    .Take(pageSize)
                    .ToList()
            };
        }

        public Post GetPost(int id)
        {
            //Tại đây ta sử dụng include để thêm các thuộc tính ta muốn lấy
            //Vì post và maincomment, subcomment giờ đây là các bảng tách biệt trong csdl
            //theninclude cho phép ta thêm 1 thuộc tính nữa sau pt include
            return _ctx.Posts
                .Include(p => p.MainComments)
                   .ThenInclude(mc => mc.SubComments) 
                .FirstOrDefault(p => p.Id == id);
        }

        public void RemovePost(int id)
        {
            _ctx.Posts.Remove(GetPost(id));
        }
        public void UpdatePost(Post post)
        {
            _ctx.Update(post);
        }

        //phương thức savechange khi được gọi mới chính thức thay đổi data trong csdl
        public async Task<bool> SaveChangesAsync()
        {
            if(await _ctx.SaveChangesAsync() > 0)
            {
                return true;
            }
            return false;
        }

        public void AddSubComment(SubComment comment)
        {
            _ctx.SubComments.Add(comment);
        }
    }
}
