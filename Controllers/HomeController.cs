using Bloger_Project_Practise.Data;
using Bloger_Project_Practise.Data.FileManager;
using Bloger_Project_Practise.Data.Repository;
using Bloger_Project_Practise.Helpers;
using Bloger_Project_Practise.Models;
using Bloger_Project_Practise.Models.Commments;
using Bloger_Project_Practise.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloger_Project_Practise.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repo;
        private IFileManager _fileManager;
        private IEmailSender _emailSender;

        public HomeController(IRepository repo, IFileManager fileManager, IEmailSender emailSender)
        {
            _repo = repo;
            _fileManager = fileManager;
            _emailSender = emailSender;
            var comment = new MainComment();
        }

        public IActionResult Index( int pageNumber, string category, string search)
        {
            //Việc đặt biến ở đây giúp ta dẽ gỡ lỗi vì có thể đặt break point ở vt này
            //việc ko khai báo biến ko giúp hiệu suất tăng lên
            //Dùng một biểu thưc luận lý để kiểm tra việc category có post nào thuộc về hay ko
            //nếu có trả theo ds cate, ko trả về tất cả post
            //boolean ? true : flase;

            //Đảm bảo số trang ko rớt xuống dưới 1 gây lỗi
            if (pageNumber < 1)
                return RedirectToAction("Index", new { pageNumber = 1, category });

            var vm = _repo.GetAllPosts(pageNumber, category, search);

            return View(vm);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contact(EmailSenderViewModel vm)
        {
            await _emailSender.SendEmailAsync(vm.Email, vm.Subject, vm.Message);
            return View(vm);
        }

        public IActionResult Gallery()
        {
            var vm = _repo.GetAllPosts();
            return View(vm);
        }

        public IActionResult Post(int id)
        {
            var post = _repo.GetPost(id);
            return View(post);
        }

        //thêm route cho phương thức lấy ảnh
        [HttpGet("/Image/{image}")]
        //Thêm chỉ định sử dụng bộ nhớ cache cho hình ảnh đã set up ở startup.cs
        [ResponseCache(CacheProfileName = "Monthly")]
        public IActionResult Image(string image)
        {
            var mine = image.Substring(image.LastIndexOf("."));
            return new FileStreamResult(_fileManager.ImageStream(image), $"image/{mine}");
        }

        [HttpPost]
        public async Task<IActionResult> Comment(CommentViewModel vm)
        {
            if(!ModelState.IsValid)
            {
                return RedirectToAction("Post", new { id = vm.PostId });
            }

            var post = _repo.GetPost(vm.PostId);
            //Ta sẽ lấy MainCommentId từ viewmodel, nếu nó bằng 0 => đó là Maincomment
            //Ngược lại ta lấy đc giá trị maincommentid tức comment lần này là sub
            if(vm.MainCommentId == 0)
            {
                //Cách 1 - ta duyệt qua hết các phần tử để xác định rằng main comment lần này là mới
                //Sau đó ta dùng pt add thêm vào, cuối cùng gọi update(post) cập nhật thay đổi
                post.MainComments = post.MainComments ?? new List<MainComment>();

                post.MainComments.Add(new MainComment
                {
                    Message = vm.Message,
                    Created = DateTime.Now
                });

                _repo.UpdatePost(post);
            }
            else
            {
                //Cách 2 - ta tạo mới 1 đối tượng sau đó gán các thuộc tính lấy đc từ vm
                //Để làm được điều này ta cần cung cấp Id của comment đó
                var comment = new SubComment
                {
                    MainCommentId = vm.MainCommentId,
                    Message = vm.Message,
                    Created = DateTime.Now
                };
                _repo.AddSubComment(comment);
            }

            await _repo.SaveChangesAsync();
            return RedirectToAction("Post", new { id = vm.PostId });
        }
       
    }
}
