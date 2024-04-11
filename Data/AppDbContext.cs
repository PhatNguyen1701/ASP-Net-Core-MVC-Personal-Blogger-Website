using Bloger_Project_Practise.Models;
using Bloger_Project_Practise.Models.Commments;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloger_Project_Practise.Data
{
    //Kế thừa IdentityDbContext để có thể sử dụng các bảng cho người dùng và thực thi xác thực
    //(tương tự cho việc khi báo bảng Posts bên dưới)
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<MainComment> MainComments { get; set; }
        public DbSet<SubComment> SubComments { get; set; }
    }
}
