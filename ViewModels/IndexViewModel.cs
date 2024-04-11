using Bloger_Project_Practise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloger_Project_Practise.ViewModels
{
    public class IndexViewModel
    {
        //Để ta có thể truyền số trang vào trong view, ta cần thiết lập như những gì đã làm
        //ở các functions trước đó, ta tạo thuộc tính số trang VM và truyền vào View
        public int PageNumber { get; set; }
        public int PageCount { get; set; }
        public bool NextPage { get; set; }
        public string Category { get; set; }
        public string Search { get; set; }
        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<int> Pages { get; set; }
    }
}
