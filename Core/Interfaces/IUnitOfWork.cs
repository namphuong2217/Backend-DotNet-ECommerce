using System;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        // initialize a repository
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;

        // complete a transaction
        Task<int> Complete();
    }
}