using Fansoft.Store.UI.Data;
using Fansoft.Store.UI.Infra.Middlewares;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Fansoft.Store.UI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(opt => {
                    opt.LoginPath = "/Conta/Login";
                });

            services.AddMvc();
            services.AddScoped(typeof(FanSoftStoreDataContext));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, FanSoftStoreDataContext ctx)
        {
            app.UseStaticFiles();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                DbInitializer.Init(ctx);
                app.UseNodeModules(env.ContentRootPath);
            }

            app.UseAuthentication();
            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                context.Response.Headers.Add("Content-type", "text/html;charset=utf-8");
                await context.Response.WriteAsync("Recurso não encontrado");
            });
        }
    }
}
