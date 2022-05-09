using NerdStore.Core.DomainObjects;
using System;
using System.Threading.Tasks;

namespace NerdStore.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}