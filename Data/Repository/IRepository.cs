using Bloger_Project_Practise.Models;
using Bloger_Project_Practise.Models.Commments;
using Bloger_Project_Practise.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloger_Project_Practise.Data.Repository
{
    //dùng interface để có thể hiện thức hóa các chức năng cần thiết một cách dễ dàng
    public interface IRepository
    {
        Post GetPost(int id);
        List<Post> GetAllPosts();
        //Thêm 1 phương thức lọc post theo category và có chia trang
        IndexViewModel GetAllPosts(int pageNumber, string category, string search);
        void AddPost(Post post);
        void RemovePost(int id);
        void UpdatePost(Post post);
        void AddSubComment(SubComment comment);

        Task<bool> SaveChangesAsync();
    }
}
