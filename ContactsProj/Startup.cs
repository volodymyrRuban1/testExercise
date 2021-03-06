using ContactProj.Domain.Context;
using ContactProj.Domain.Entities;
using ContactProj.Domain.FluentValidation;
using ContactProj.Infrastructure;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;

namespace ContactsProj.WebApi
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
			services.AddDbContext<ContactProjContext>(options =>
				options.UseSqlServer(Configuration.GetConnectionString("ContactProj")));

			services.AddControllers()
				.AddFluentValidation(configuration =>
					configuration.RegisterValidatorsFromAssemblyContaining<Startup>())
				.AddNewtonsoftJson(
					options => {
						options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
					});

			services.AddHttpClient();

			// Adding services
			services.AddInfrastructure(Configuration);

			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "ContactsProj", Version = "v1" });
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseSwagger();
				app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ContactsProj v1"));
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
