using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace capp.TimePie
{
    public class Startup 
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc(routes =>{
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"
                    );
            });
        }

       
    }
}