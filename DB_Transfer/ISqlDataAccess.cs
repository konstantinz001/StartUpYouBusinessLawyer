namespace DB_Transfer
{
    public interface ISqlDataAccess
    {
        string ConnectionStringName { get; set; }

        Task<List<T>> LoadDataAsync<T, U>(string sql, U parameters);
        Task SaveDataAsync<T>(string sql, T parameters);
    }
}