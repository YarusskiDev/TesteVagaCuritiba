using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteWebApiCompras.Context;
using TesteWebApiCompras.Interfaces;
using TesteWebApiCompras.Interfaces.IRepositorios;
using TesteWebApiCompras.Interfaces.Servicos;
using TesteWebApiCompras.Repositorios;
using TesteWebApiCompras.Servicos;

namespace TesteWebApiCompras
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
            services.AddControllers().AddNewtonsoftJson(opt => 
            opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddScoped<MeuContexto>();
            services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
            services.AddScoped<IEmpresaRepositorio, EmpresaRepositorio>();
            services.AddScoped<ICompraRepositorio, CompraRepositorio>();
            services.AddScoped<IItensCompraRepositorio, ItensCompraRepositorio>();

            services.AddScoped<ICompraServico, CompraServico>();
            services.AddScoped<IEmpresaServico, EmpresaServico>();
            services.AddScoped<IProdutoServico, ProdutoServico>();
            services.AddScoped<IItensCompraServico, ItensCompraServico>();

            services.AddDbContext<MeuContexto>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MinhaConexao")));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TesteWebApiCompras", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TesteWebApiCompras v1"));
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
