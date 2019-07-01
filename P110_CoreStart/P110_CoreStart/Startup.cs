using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace P110_CoreStart
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            #region MiddleWare and Request Pipeline
            ////MiddleWare 1
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Xos gelmisen, P110\n");
            //    await next();
            //});

            ////MiddleWare 2
            //app.Use(async (context, next) =>
            //{
            //    if(3 > 4)
            //    {
            //        await context.Response.WriteAsync("Xos getdin, P110\n");
            //    }
            //    else
            //    {
            //        await next();
            //    }
            //});

            //////MiddleWare 3
            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Medine ve P110\n");
            //});
            #endregion

            app.UseMvc(routes => {
                routes.MapRoute(
                    "default",
                    "{controller=Home}/{action=Index}" //controller - class, action - method
                );
            });
        }
    }
}
