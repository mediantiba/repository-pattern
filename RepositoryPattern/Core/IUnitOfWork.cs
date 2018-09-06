using System;

namespace RepositoryPattern.Core
{
    public interface IUnitOfWork : IDisposable
    {
        // Add interfaces for other repositories here.

        void Complete();
    }
}