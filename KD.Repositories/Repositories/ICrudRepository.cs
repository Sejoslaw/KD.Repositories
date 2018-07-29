namespace KD.Repositories.Repositories
{
    /// <summary>
    /// Represents a repository which performs CRUD operations on specified entity type.
    /// </summary>
    /// <typeparam name="TId"> Represents an identifier which is used as a primary key of entity. </typeparam>
    /// <typeparam name="TEntity"> Represents a type of entity on which repository performs CRUD repository. </typeparam>
    public interface ICrudRepository<TId, TEntity> : IRepository<TEntity>
    {
        /// <summary>
        /// Creates new record of specified entity.
        /// </summary>
        /// <param name="entity"> Entity which should be created / added into data source. </param>
        void Create(TEntity entity);
        /// <summary>
        /// Reads record from data source using specified id.
        /// </summary>
        /// <param name="id"> Id by which entity is read. </param>
        /// <returns> Returns object from data source. </returns>
        TEntity Read(TId id);
        /// <summary>
        /// Updates specified record in data source.
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);
        /// <summary>
        /// Deletes record from data source.
        /// </summary>
        /// <param name="id"></param>
        void Delete(TId id);
    }
}
