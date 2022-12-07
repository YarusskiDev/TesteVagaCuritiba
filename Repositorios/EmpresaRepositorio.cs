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
    public class EmpresaRepositorio : RepositorioBase<Empresa>, IEmpresaRepositorio
    {
        public EmpresaRepositorio(MeuContexto db) : base(db)
        {
        }
    }
}
