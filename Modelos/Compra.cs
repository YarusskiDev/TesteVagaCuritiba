using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TesteWebApiCompras.Modelos
{
    public class Compra : Entidade
    {
        [ForeignKey("IdCliente")]
        public int IdCliente { get; set; }
     
        public virtual Empresa Empresa { get; set; }
        public virtual List<ItensCompras> Itens { get; set; }
    }
}
