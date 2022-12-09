using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteWebApiCompras.Contexto;
using TesteWebApiCompras.Modelos;

namespace TesteWebApiCompras.Context
{
    public class MeuContexto:DbContext
    {

        public MeuContexto(DbContextOptions options) : base(options)
        {
        
        }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<ItensCompras> ItensCompras { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)

        //{

        //    modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuContexto).Assembly);

        //    modelBuilder.ApplyConfiguration(new ComprasConfiguracao());
        //    modelBuilder.ApplyConfiguration(new EmpresaConfiguracao());
        //    modelBuilder.ApplyConfiguration(new ItensCompraConfiguracao());
        //    modelBuilder.ApplyConfiguration(new ProdutoConfiguracao());
        //}
    }
}
