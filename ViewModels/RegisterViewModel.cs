using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloger_Project_Practise.ViewModels
{
    public class RegisterViewModel
    {
        //Tại RegisterVM này ta dùng các anotation để thiết lập xác thực data
        //Trước khi đưa vào lưu ở csdl như định dạng email, định dạng password như đã làm
        //Tại thuộc tính confirm password ta còn phải so sánh với dòng password phía trước đó
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
