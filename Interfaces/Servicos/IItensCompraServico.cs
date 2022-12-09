using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteWebApiCompras.Modelos;

namespace TesteWebApiCompras.Interfaces.Servicos
{
    public interface IItensCompraServico
    {
        Task Adicionar(ItensCompras itensCompras);
        Task Atualizar(ItensCompras itensCompras);
        Task Remover(int id);

    }
}
