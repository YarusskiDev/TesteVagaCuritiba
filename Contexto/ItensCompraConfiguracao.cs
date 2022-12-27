using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteWebApiCompras.Modelos;

namespace TesteWebApiCompras.Contexto
{
    public class ItensCompraConfiguracao : IEntityTypeConfiguration<ItensCompras>
    {
        public void Configure(EntityTypeBuilder<ItensCompras> builder)
        {
        
            
        }


    }
}
