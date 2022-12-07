using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteWebApiCompras.Modelos;

namespace TesteWebApiCompras.Interfaces.servicos
{
    public interface IProdutoServico
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Inserir(Produto produto);
        Task Remover(int id);
    }
}
