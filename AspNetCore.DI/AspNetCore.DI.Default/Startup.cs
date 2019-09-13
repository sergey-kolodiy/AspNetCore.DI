using AspNetCore.DI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCore.DI.Default
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<S01>();
            services.AddScoped<S02>();
            services.AddScoped<S03>();
            services.AddScoped<S04>();
            services.AddScoped<S05>();
            services.AddScoped<S06>();
            services.AddScoped<S07>();
            services.AddScoped<S08>();
            services.AddScoped<S09>();
            services.AddScoped<S10>();
            services.AddScoped<S11>();
            services.AddScoped<S12>();
            services.AddScoped<S13>();
            services.AddScoped<S14>();
            services.AddScoped<S15>();
            services.AddScoped<S16>();
            services.AddScoped<S17>();
            services.AddScoped<S18>();
            services.AddScoped<S19>();
            services.AddScoped<S20>();
            services.AddScoped<S21>();
            services.AddScoped<S22>();
            services.AddScoped<S23>();
            services.AddScoped<S24>();
            services.AddScoped<S25>();
            services.AddScoped<S26>();
            services.AddScoped<S27>();
            services.AddScoped<S28>();
            services.AddScoped<S29>();
            services.AddScoped<S30>();
            services.AddScoped<S31>();
            services.AddScoped<S32>();
            services.AddScoped<S33>();
            services.AddScoped<S34>();
            services.AddScoped<S35>();
            services.AddScoped<S36>();

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
