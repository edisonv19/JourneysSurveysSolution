using Infrastructure.DbContext.Utils;
using System.Data;
using System.Data.SqlClient;

namespace Infrastructure.DbContext
{
    internal static class DbSqlServerUtils
    {
        // creates a list of an object from the given data table
        internal static IEnumerable<T> GetDataList<T>(DataRowCollection rows) where T : new()
        {
            var list = new List<T>();

            // go through each row
            foreach (DataRow r in rows)
            {
                var obj = new T();

                SetObj(obj, r);

                list.Add(obj);
            }

            return list;
        }

        internal static IEnumerable<SqlParameter> CreateParameters(IEnumerable<Parameter> parameters)
        {
            var sqlParameters = new List<SqlParameter>();

            foreach (var item in parameters)
            {
                SqlParameter sqlParameter = item.Type switch
                {
                    DbTypes.Integer => new SqlParameter($"@{item.Name}", SqlDbType.Int, item.Size, ParameterDirection.Input, item.IsNullable, 0, 0, null, DataRowVersion.Original, (int)item.Value),
                    DbTypes.Varchar => new SqlParameter($"@{item.Name}", SqlDbType.VarChar, item.Size, ParameterDirection.Input, item.IsNullable, 0, 0, null, DataRowVersion.Original, (string)item.Value),
                    DbTypes.DateTime => new SqlParameter($"@{item.Name}", SqlDbType.DateTime, item.Size, ParameterDirection.Input, item.IsNullable, 0, 0, null, DataRowVersion.Original, (DateTime)item.Value),
                    DbTypes.Time => new SqlParameter($"@{item.Name}", SqlDbType.Time, item.Size, ParameterDirection.Input, item.IsNullable, 0, 0, null, DataRowVersion.Original, (TimeSpan)item.Value),
                    DbTypes.Decimal => new SqlParameter($"@{item.Name}", SqlDbType.Decimal, item.Size, ParameterDirection.Input, item.IsNullable, 0, 0, null, DataRowVersion.Original, (decimal)item.Value),
                    DbTypes.Float => new SqlParameter($"@{item.Name}", SqlDbType.Float, item.Size, ParameterDirection.Input, item.IsNullable, 0, 0, null, DataRowVersion.Original, (float)item.Value),
                    _ => new SqlParameter(),
                };
                sqlParameters.Add(sqlParameter);
            }

            return sqlParameters;
        }

        private static void SetObj<T>(T obj, DataRow row)
        {
            // go through each column
            foreach (DataColumn c in row.Table.Columns)
            {
                var p = obj?.GetType().GetProperty(c.ColumnName);

                if (p != null && row[c] != DBNull.Value)
                {
                    p.SetValue(obj, row[c], null);
                }
            }
        }
    }
}
