using Estidiante.Dominio.Repositorio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;

namespace Estidiante.Infraestructura.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly EstudianteContexto _dbContext;
        public UnitOfWork(EstudianteContexto dbContext)
        {
            _dbContext = dbContext;
        }

        public IDbTransaction BeginTransaction(IsolationLevel isolationLevel)
        {
            var transaction = _dbContext.Database.BeginTransaction(isolationLevel);
            return transaction.GetDbTransaction();
        }

        public async Task guardar() { 
            await _dbContext.SaveChangesAsync();
        }

    }
}
