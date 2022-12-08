using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TesteWebApiCompras.Context;
using TesteWebApiCompras.Interfaces;
using TesteWebApiCompras.Modelos;

namespace TesteWebApiCompras.Repositorios
{
    public class ProdutoRepositorio : RepositorioBase<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(MeuContexto db) : base(db)
        {
        }
    }
}
