using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloger_Project_Practise.Data.FileManager
{
    //IFileManager tương tự như IRepository nhưng mục đích là xử lý các loại tệp
    public interface IFileManager
    {
        FileStream ImageStream(string image);
        Task<string> SaveImage(IFormFile image);
        bool RemoveImage(string image);
    }
}
