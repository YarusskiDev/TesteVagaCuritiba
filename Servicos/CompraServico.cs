using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteWebApiCompras.Interfaces;
using TesteWebApiCompras.Modelos;

namespace TesteWebApiCompras.Servicos
{
    public class CompraServico : ICompraServico
    {
        private ICompraRepositorio _comprasRepositorio;
        public CompraServico(ICompraRepositorio comprasRepositorio)
        {
            _comprasRepositorio = comprasRepositorio;
        }
        public Task Adicionar(Compra compra)
        {
            return _comprasRepositorio.Adicionar(compra);          
        }

        public Task Atualizar(Compra compra)
        {
            return _comprasRepositorio.Atualizar(compra);
        }
        public Task BuscarPorId(int Id)
        {
            return _comprasRepositorio.ObterPorId(Id);
        }

        public Task BuscarTodos()
        {
            return _comprasRepositorio.ObterTodos();
        }

        public Task Remover(int Id)
        {
            return _comprasRepositorio.Remover(Id);
        }
    }
}
