using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TesteWebApiCompras.Modelos
{
    public class ItensCompras : Entidade
    {

        public int IdCompra { get; set; }

        public int IdProduto { get; set; }

        public int Quantidade { get; set; }

        [JsonIgnore]
        [ForeignKey("IdCompra")]
        public virtual Compra Compra { get; set; }

        [JsonIgnore]
        [ForeignKey("IdProduto")]
        public virtual Produto Produto { get; set; }

    }
}
