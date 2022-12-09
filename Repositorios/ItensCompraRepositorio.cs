using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteWebApiCompras.Context;
using TesteWebApiCompras.Interfaces.IRepositorios;
using TesteWebApiCompras.Modelos;

namespace TesteWebApiCompras.Repositorios
{
    public class ItensCompraRepositorio : RepositorioBase<ItensCompras>,IItensCompraRepositorio
    {
        public ItensCompraRepositorio(MeuContexto db) : base(db)
        {

        }
    }
}
