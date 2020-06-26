using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandLineAPI.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CommandLineAPI
{
 public class Startup
 {
  public Startup(IConfiguration configuration)
  {
   Configuration = configuration;
  }

  public IConfiguration Configuration { get; }

  // This method gets called by the runtime. Use this method to add services to the container.
  public void ConfigureServices(IServiceCollection services)
  {
   services.AddControllers();
   services.AddScoped<ICommandLineRepo, PsqlCommandRepo>();
   services.AddDbContext<CommandLineAPIContext>(options => options.UseNpgsql(Configuration.GetConnectionString("CommandLineConnection")));

  }

  // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
  public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
  {
   if (env.IsDevelopment())
   {
    app.UseDeveloperExceptionPage();
   }

   app.UseHttpsRedirection();

   app.UseRouting();

   app.UseAuthorization();

   app.UseEndpoints(endpoints =>
   {
    endpoints.MapControllers();
   });
  }
 }
}
