using Bloger_Project_Practise.Data.FileManager;
using Bloger_Project_Practise.Data.Repository;
using Bloger_Project_Practise.Models;
using Bloger_Project_Practise.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloger_Project_Practise.Controllers
{
    //Thuộc tính Authorize đánh dấu chỉ khi user đc authorize có một vai tro mà ta chỉ định
    //User đó mới có thể truy cập sử dụng các chức năng của Panel
    //Ta củng có thể chỉ định thuộc tính này cho các action bên trong controller
    //Tham số Roles thiết lập chính xác Role cụ thể ở đây là Admin, mới có thể truy xuất controller này
    [Authorize(Roles ="Admin")]
    public class PanelController : Controller
    {
        //Tạo Panel Controller để thực hiện trang quản trị của Admin
        private IRepository _repo;
        private IFileManager _fileManager;

        public PanelController(IRepository repo, IFileManager fileManager)
        {
            _repo = repo;
            _fileManager = fileManager;
        }
        public IActionResult Index()
        {
            //Việc đặt biến ở đây giúp ta dẽ gỡ lỗi vì có thể đặt break point ở vt này
            //việc ko khai báo biến ko giúp hiệu suất tăng lên
            var posts = _repo.GetAllPosts();
            return View(posts);
        }
        [HttpGet]
        //Sử dụng int? vì chưa viết bài đăng này chưa được tạo ra(mới) hay đã có rồi(chỉnh sửa được)
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return View(new PostViewModel());
            else
            {
                //Int? không phải là kiểu số nguyên nên cần Paste về giá trị số nguyên
                var post = _repo.GetPost((int)id);
                //Khi đã sử dụng viewmodel, trong TH bài post đã có ta khởi tạo lại các thuộc 
                //tính đã chỉnh sửa và trả nó về View
                return View(new PostViewModel
                {
                    Id = post.Id,
                    Title = post.Title,
                    Body = post.Body,
                    CurrentImage = post.Image,
                    Description = post.Description,
                    Category = post.Category,
                    Tags = post.Tags
                });
            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(PostViewModel vm)
        {
            var post = new Post {
                Id = vm.Id,
                Title = vm.Title,
                Body = vm.Body,
                Description = vm.Description,
                Category = vm.Category,
                Tags = vm.Tags,
                Image = await _fileManager.SaveImage(vm.Image)
            };

            if(vm.Image == null)
            {
                post.Image = vm.CurrentImage;
            }
            else
            {
                //Sửa dụng phương thức remove image để xóa đi hình ảnh cũ thay vì ghi đè như đã làm
                if (!string.IsNullOrEmpty(vm.CurrentImage))
                    _fileManager.RemoveImage(vm.CurrentImage);

                post.Image = await _fileManager.SaveImage(vm.Image);
            }

            //Ta cần kiểm tra id có bằng 0 (blog mới chưa tạo) hay ko trước khi sử dụng 1 trong 2 phương thức
            if (post.Id > 0)
                _repo.UpdatePost(post);
            else
                _repo.AddPost(post);

            if (await _repo.SaveChangesAsync())
                return RedirectToAction("Index", "Panel");
            else
                return View(post);
        }
        [HttpGet]
        public async Task<IActionResult> Remove(int id)
        {
            _repo.RemovePost(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
