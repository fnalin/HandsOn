using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fansoft.Store.UI.Data;
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
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                using (var ctx = new FanSoftStoreDataContext())
                {
                    DbInitializer.Init(ctx);

                }
            }

            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                context.Response.Headers.Add("Content-type","text/html;charset=utf-8");
                await context.Response.WriteAsync("Recurso não encontrado");
            });
        }
    }
}
