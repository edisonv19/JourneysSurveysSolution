using System.Data;

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
