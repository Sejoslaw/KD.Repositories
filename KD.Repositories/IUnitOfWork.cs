using KD.Repositories.Repositories;
using KD.Repositories.Services;

namespace KD.Repositories
{
    /// <summary>
    /// Represents a container which contains global information about all registered services and repositories.
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Returns all currently registered repositories.
        /// </summary>
        IRepository[] RegisteredRepositories { get; }
        /// <summary>
        /// Returns all currently registered services.
        /// </summary>
        IService[] RegisteredServices { get; }
    }
}
