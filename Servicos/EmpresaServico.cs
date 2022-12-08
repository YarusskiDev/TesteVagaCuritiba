using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteWebApiCompras.Interfaces;
using TesteWebApiCompras.Interfaces.servicos;
using TesteWebApiCompras.Modelos;

namespace TesteWebApiCompras.Servicos
{
    public class EmpresaServico:IEmpresaServico
    {
        private IEmpresaRepositorio _empresaRepositorio;
        public EmpresaServico(IEmpresaRepositorio empresaRepositorio)
        {
            _empresaRepositorio = empresaRepositorio;
        }

        public Task Adicionar(Empresa empresa)
        {
            return _empresaRepositorio.Adicionar(empresa);
        }

        public Task Atualizar(Empresa empresa)
        {
            return _empresaRepositorio.Atualizar(empresa);
        }

        public Task Remover(int id)
        {
            return _empresaRepositorio.Remover(id);
        }
    }
}
