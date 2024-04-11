using Bloger_Project_Practise.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bloger_Project_Practise.Data.Repository;
using Microsoft.AspNetCore.Identity;
using Bloger_Project_Practise.Data.FileManager;
using Microsoft.AspNetCore.Mvc;
using Bloger_Project_Practise.Helpers;

namespace Bloger_Project_Practise
{
    public class Startup
    {
        //Tạo contructor mang Configuration để thưc hiện liên kết dbcontext và csdl
        private IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Tạo liên kết giữa dbcontext và csdl, thông qua chuỗi kết nối đặt trong appsettings.json
            //việc tạo chuỗi kết nối trong appsettings.json để đảm bảo bảo mật
            //Tại NetCore 3.1 cần có Entity Core Tool và Entity Core SqlServer 
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(_config["DefaultConnection"]));

            //Thêm service DefaultIdentity phục vụ cho việc xác thực đăng nhập
            //Thay đỏi thành AddIdentity và thêm 1 tham số IdentityRole
            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                //Hiệu chỉnh setting tiêu chuẩn của password ở đây
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
            })
                //.AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<AppDbContext>();

            //Thêm Service ConfigureApplicationCookie để config Cookie lưu giữ thông tin Login
            //SẼ tìm hiểu thêm
            services.ConfigureApplicationCookie(options => {
                options.LoginPath = "/Auth/Login";
            });

            //khai báo sử dụng Transient với tham số là Repositoty đã tạo
            services.AddTransient<IRepository, Repository>();

            //Khai báo sử dụng Transient với tham số là FileManager đã tạo
            services.AddTransient<IFileManager, FileManager>();

            //Khai báo sử dụng Transient với tham số là EmailSender đã tạo
            services.AddTransient<IEmailSender, EmailSender>();

            //sử dụng các chức năng của MVC
            //Thiết lập Image Cache
            services.AddMvc(options =>
            {
                //Ta thêm chỉ định hạn của bộ nhớ cache
                //60 giây x 60 phút x 24 giờ x 7 ngày x 4 = 1 tháng
                options.CacheProfiles.Add("Monthly", new CacheProfile { Duration = 60 * 60 * 24 * 7 * 4 });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //Ta dua cau hinh nay ra ngoai moi truong phat trien trong truong hop publishing web
                //Sau khi đã đưa ra ngoài, ta sẽ ko thể dùng IIS cho development của visual đc nữa
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            //Khai báo sử dụng Satic File để truyền tải hình ảnh
            app.UseStaticFiles();

            //Khai báo sử dụng xác thực (Enable Authen v.v.)
            app.UseAuthentication();

            app.UseAuthorization(); // Cần sử dụng Author trong Netcore 3.1, đặt giữa UseRouting và UserEndpoint

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
            //Add migration để cập nhập vào csdl các bảng của Identity sau khi sử dụng Authen
        }
    }
}
