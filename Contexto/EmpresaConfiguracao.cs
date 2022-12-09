using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteWebApiCompras.Modelos;

namespace TesteWebApiCompras.Contexto
{
    public class EmpresaConfiguracao : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("Empresas");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).HasColumnType("VARCHAR(50)").IsRequired();
        }
    }
}
