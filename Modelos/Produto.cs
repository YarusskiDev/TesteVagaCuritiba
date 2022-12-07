using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TesteWebApiCompras.Modelos
{
    public class Produto : Entidade
    {
        public string Nome { get; set; }
    }
}
