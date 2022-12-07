using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteWebApiCompras.Modelos;

namespace TesteWebApiCompras.Interfaces.servicos
{
    public interface IEmpresaServico
    {
        Task Adicionar(Empresa empresa);
        Task Atualizar(Empresa empresa);

        Task Inserir(Empresa empresa);
        Task Remover(int id);

    }
}
