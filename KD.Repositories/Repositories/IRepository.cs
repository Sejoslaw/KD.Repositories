namespace KD.Repositories.Repositories
{
    /// <summary>
    /// Represents the middle level in repository pattern.
    /// Uses data source context to perform specific operations directly on data source.
    /// </summary>
    /// <typeparam name="TEntity"> Represents a type of entity on which repository performs specific operations. </typeparam>
    public interface IRepository<TEntity> : IRepository
    {
    }

    /// <summary>
    /// Represents the middle level in repository pattern.
    /// Uses data source to perform operations on specified data source.
    /// </summary>
    public interface IRepository
    {
    }
}
