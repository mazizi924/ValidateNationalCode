using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using ValidateNationalCode.Infrustructure;

namespace ValidateNationalCode
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<RouteOptions>(options => 
            options.ConstraintMap.Add("FormatNationalCode", typeof(FormatNationalCodeConstraint)));
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(route=>
             // route.MapRoute("default", "/{Controller}/{Action}/{NationalCode:FormatNationalCode}"));
              route.MapRoute("default", "/{Controller}/{Action}/{NationalCode:regex([0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9][0-9]-[0-9])}"));
          
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
