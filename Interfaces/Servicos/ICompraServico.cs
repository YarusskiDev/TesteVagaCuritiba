using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteWebApiCompras.Modelos;

namespace TesteWebApiCompras.Interfaces
{
    public interface ICompraServico
    {
        Task BuscarTodos();
        Task BuscarPorId(int Id);
        Task Adicionar(Compra compra);
        Task Atualizar(Compra compra);
        Task Remover(int id);
    }
}
