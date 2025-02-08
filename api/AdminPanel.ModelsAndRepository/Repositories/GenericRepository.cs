using Dapper;
using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using System.Reflection;
using AdminPanel.ModelsAndRepository.Models;
using System.Text;

namespace AdminPanel.ModelsAndRepository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : IEntity
    {
        private readonly IDbConnection _connection;
        private readonly string _tableName;

        public GenericRepository(IDbConnection connection) {
            _connection = connection;
            TableAttribute tableAttribute = typeof(T).GetCustomAttribute<TableAttribute>();
            _tableName = tableAttribute?.Name ?? typeof(T).Name;
        }

        public async Task<T> CreateAsync(T entity) {
            if (_connection.State != ConnectionState.Open) {
                _connection.Open();
            }

            using (IDbTransaction transaction = _connection.BeginTransaction()){
                try {
                    var properties = typeof(T).GetProperties().Where(p => p.Name != "Id");
                    string columns = string.Join(", ", properties.Select(p => p.Name));
                    string parameters = string.Join(", ", properties.Select(p => $"@{p.Name}"));

                    string sql = $@"
                        INSERT INTO {_tableName} ({columns})
                        VALUES ({parameters});
                        SELECT LAST_INSERT_ID();";

                    ulong id = await _connection.ExecuteScalarAsync<ulong>(sql, entity, transaction);
                    transaction.Commit();

                    entity.Id = id;
                    return entity;
                } catch (Exception) {
                    transaction.Rollback();
                    throw;
                } finally {
                    _connection.Close();
                }
            }
        }

        public async Task DeleteAsync(T entity) {
            if (_connection.State != ConnectionState.Open) {
                _connection.Open();
            }

            using (IDbTransaction transaction = _connection.BeginTransaction()) {
                try {
                    string sql = $"DELETE FROM {_tableName} WHERE Id = @Id";
                    await _connection.ExecuteAsync(sql, new { entity.Id }, transaction);
                    transaction.Commit();
                } catch (Exception) {
                    transaction.Rollback();
                    throw;
                } finally {
                    _connection.Close();
                }
            }
        }

        public async Task<IEnumerable<T>> ListAsync(QueryParameters? queryParams) {
            if (_connection.State != ConnectionState.Open) {
                _connection.Open();
            }
            try {
                StringBuilder sqlBuilder = new($@"SELECT * FROM {_tableName}");
                DynamicParameters parameters = new();

                bool hasFilters = queryParams.Filters != null && queryParams.Filters.Count > 0;

                if (hasFilters) {
                    sqlBuilder.Append(" WHERE ");

                    bool isFirstFilter = true;
                    int paramIndex = 0; // Ensures unique parameter names

                    foreach (Filter filter in queryParams.Filters) {
                        if (!isFirstFilter) {
                            sqlBuilder.Append(" AND ");
                        }

                        string paramName = $"{filter.Field}_{paramIndex}"; 
                        parameters.Add(paramName, filter.Value);
                        sqlBuilder.Append($" {filter.Field} {filter.ConstraintOperator} @{paramName} ");

                        isFirstFilter = false;
                        paramIndex++;
                    }
                }

                if (!string.IsNullOrEmpty(queryParams.SortField)) {
                    sqlBuilder.Append($" ORDER BY {queryParams.SortField} {queryParams.SortOrder ?? "ASC"}");
                }

                if (queryParams.Page.HasValue && queryParams.PerPage.HasValue) {
                    int offset = (queryParams.Page.Value - 1) * queryParams.PerPage.Value;
                    sqlBuilder.Append($" LIMIT {queryParams.PerPage} OFFSET {offset} ");
                }

                return await _connection.QueryAsync<T>(sqlBuilder.ToString(), parameters);
            } finally {
                _connection.Close();
            }
        }

        public async Task<T?> GetAsync(ulong id) {
            if (_connection.State != ConnectionState.Open) {
                _connection.Open();
            }

            try {
                string sql = $@"SELECT * FROM {_tableName} WHERE Id = @Id";
                return await _connection.QuerySingleOrDefaultAsync<T>(sql, new { Id = id });
            } finally {
                _connection.Close();
            }
        }

        public async Task<T> UpdateAsync(T entity) {
            if (_connection.State != ConnectionState.Open) {
                _connection.Open();
            }

            using (IDbTransaction transaction = _connection.BeginTransaction()) {
                try {
                    var properties = typeof(T).GetProperties().Where(p => p.Name != "Id");
                    string setClause = string.Join(", ", properties.Select(p => $"{p.Name} = @{p.Name}"));
                    string sql = $@"UPDATE {_tableName} SET {setClause} WHERE Id = @Id";

                    await _connection.ExecuteAsync(sql, entity, transaction);
                    transaction.Commit();
                    return entity;
                } catch (Exception) {
                    transaction.Rollback();
                    throw;
                } finally {
                    _connection.Close();
                }
            }
        }
    }
}
