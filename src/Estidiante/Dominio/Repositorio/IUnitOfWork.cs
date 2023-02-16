using System.Data;

namespace Estidiante.Dominio.Repositorio
{
    public interface IUnitOfWork
    {
        Task guardar();
        IDbTransaction BeginTransaction(IsolationLevel isolationLevel);
    }
}
