using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteWebApiCompras.Modelos
{
    public class ItensCompras : Entidade
    {

        [ForeignKey("IdCompra")]
        public int IdCompra { get; set; }

        [ForeignKey("IdProduto")]
        public int IdProduto { get; set; }

        public int Quantidade { get; set; }

        public virtual Compra Compra { get; set; }

        public virtual Produto Produto { get; set; }

    }
}
