using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TesteWebApiCompras.Modelos
{
    public class Empresa:Entidade
    {
        public string Nome { get; set; }

        [JsonIgnore]
        public virtual List<Compra> Compras { get; set; }
    }
}
