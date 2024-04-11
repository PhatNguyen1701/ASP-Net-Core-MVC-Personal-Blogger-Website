using Bloger_Project_Practise.Models.Commments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloger_Project_Practise.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Body { get; set; } = "";
        //thêm thuộc tính Image chứa đường dẫn ảnh
        //Add migration và update database để thay đổi csdl
        public string Image { get; set; } = "";

        //Thêm các thuộc tính miêu tả loại post
        //Tiếp tục Add Migration để cập nhật csdl 
        public string Description { get; set; } = "";
        public string Tags { get; set; } = "";
        public string Category { get; set; } = "";
        public DateTime Created { get; set; } = DateTime.Now;
        public List<MainComment> MainComments { get; set; }
    }
    //Sau khi đã có post table, add migration để khởi tạo data và update database

    //Khởi tạo các thư mục tại wwwroot chứa hình ảnh và các file tĩnh
    //Thêm mã tại appsetting.json khai báo đường dẫn ảnh
}
