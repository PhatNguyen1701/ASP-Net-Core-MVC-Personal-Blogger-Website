using Bloger_Project_Practise.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bloger_Project_Practise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Sử dụng DependencyInjection để trước khi chương trình chạy, ta chuẩn bị trước các phương thức xác thực
            var host = CreateHostBuilder(args).Build();

            try
            {
                var scope = host.Services.CreateScope();

                var ctx = scope.ServiceProvider.GetRequiredService<AppDbContext>();//bối cảnh data
                var userMgr = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();//Quản lý User
                var roleMgr = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();//Quản lý vai trò

                ctx.Database.EnsureCreated();//đảm bảo csdl đc tạo

                var adminRole = new IdentityRole("Admin");
                //Nếu kiểm tra chưa có một role nào tồn tại, ta khởi tạo role admin
                if (!ctx.Roles.Any())
                {
                    //create role
                    roleMgr.CreateAsync(adminRole).GetAwaiter().GetResult();
                }

                //Tương tự cho user admin
                if (!ctx.Users.Any(u => u.UserName == "admin"))
                {
                    //create an admin
                    var adminUser = new IdentityUser
                    {
                        UserName = "admin",
                        Email = "admin@test.com"
                    };
                    //Thêm admin vừa tạo ở trên vào trong csdl
                    //Tại đây ta cần đặt tham số "password" theo tiêu chuẩn
                    //Để hạn chế điều đó ta sẽ hiệu chỉnh cấu hình tại startup.cs
                    var result = userMgr.CreateAsync(adminUser, "password").GetAwaiter().GetResult();
                    //Thêm role vừa tạo ở trên cho admin
                    userMgr.AddToRoleAsync(adminUser, adminRole.Name).GetAwaiter().GetResult();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
