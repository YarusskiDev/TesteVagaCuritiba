using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TesteWebApiCompras.Modelos
{
    public class Empresa:Entidade
    {
        public string Nome { get; set; }

        public virtual List<Compra> Compras { get; set; }
    }
}
