using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloger_Project_Practise.ViewModels
{
    //Khởi tạo PostViewModel lưu trữ các thông tin cơ bản của post thay cho PostModel
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Body { get; set; } = "";
        public string Description { get; set; } = "";
        public string Tags { get; set; } = "";
        public string Category { get; set; } = "";
        public string CurrentImage { get; set; } = "";
        //IFormFile là một giao diện cơ bản cho việc lưu trữ image hay video
        public IFormFile Image { get; set; } = null;
    }
}
