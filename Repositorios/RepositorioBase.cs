using Microsoft.EntityFrameworkCore;
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
    public class RepositorioBase<TEntidade> : IRepositorio<TEntidade> where TEntidade : Entidade, new()
    {
        protected readonly MeuContexto Db;
        protected readonly DbSet<TEntidade> DbSet;
        public RepositorioBase(MeuContexto db)
        {
            Db = db;
            DbSet = db.Set<TEntidade>();
        }
        public async Task Adicionar(TEntidade entidade)
        {
            try
            {
                DbSet.Add(entidade);
                await SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task Atualizar(TEntidade entidade)
        {
            DbSet.Update(entidade);
            await SaveChanges();
        }

        public async Task<IEnumerable<TEntidade>> Buscar(Expression<Func<TEntidade, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }

        public async Task<TEntidade> ObterPorId(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task<List<TEntidade>> ObterTodos()
        {
            return await DbSet.ToListAsync();
        }

        public async Task Remover(int id)
        {
            try
            {
                DbSet.Remove(new TEntidade { Id = id });
                await SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }
        public int SaveChangesTeste()
        {
            return Db.SaveChanges();
        }
    }
}
