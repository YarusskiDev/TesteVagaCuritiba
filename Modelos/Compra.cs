using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TesteWebApiCompras.Modelos
{
    public class Compra : Entidade
    {        
        public int IdEmpresa { get; set; }

        [JsonIgnore]
        [ForeignKey("IdEmpresa")]
        public virtual Empresa Empresa { get; set; }
        [JsonIgnore]
        public virtual List<ItensCompras> Itens { get; set; }
    }
}
