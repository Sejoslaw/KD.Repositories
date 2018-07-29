namespace KD.Repositories.DataSources
{
    /// <summary>
    /// Represents the lowest level of repository pattern.
    /// Contains information about direct connection to data source.
    /// </summary>
    public interface IDataSource : IDataSource<object>
    {
    }

    /// <summary>
    /// Represents the lowest level of repository pattern.
    /// Contains information about direct connection to data source.
    /// </summary>
    /// <typeparam name="TSource"> Represents a type of data source. </typeparam>
    public interface IDataSource<TSource>
    {
        /// <summary>
        /// Represents a data source.
        /// </summary>
        TSource DataSource { get; }
    }
}
