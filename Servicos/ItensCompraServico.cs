using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteWebApiCompras.Interfaces.IRepositorios;
using TesteWebApiCompras.Interfaces.Servicos;
using TesteWebApiCompras.Modelos;

namespace TesteWebApiCompras.Servicos
{
    public class ItensCompraServico: IItensCompraServico
    {

        private IItensCompraRepositorio _itensCompraRepositorio;
        public ItensCompraServico(IItensCompraRepositorio itensCompraRepositorio)
        {
            _itensCompraRepositorio = itensCompraRepositorio;
        }

        public Task Adicionar(ItensCompras itensCompras)
        {
            return _itensCompraRepositorio.Adicionar(itensCompras);
        }

        public Task Atualizar(ItensCompras itensCompras)
        {
            return _itensCompraRepositorio.Atualizar(itensCompras);
        }

        public Task Remover(int id)
        {
            return _itensCompraRepositorio.Remover(id);
        }
    }
}
