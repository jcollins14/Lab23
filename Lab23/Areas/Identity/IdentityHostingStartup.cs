using System;
using Lab23.Areas.Identity.Data;
using Lab23.DAL;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Lab23.Areas.Identity.IdentityHostingStartup))]
namespace Lab23.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ShopDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ShopDBContextConnection")));

                services.AddDefaultIdentity<ShopDBUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<ShopDBContext>();
            });
        }
    }
}