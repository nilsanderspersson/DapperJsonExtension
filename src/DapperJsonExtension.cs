using System;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Dapper
{
    public static class DapperJsonExtension
    {
        public static dynamic QueryJson(this IDbConnection connection, string sql,
                                        object param = null, IDbTransaction transaction = null,
                                        bool buffered = false, int? commandTimeout = null, CommandType? commandType = null,
                                        string defaultOutput = "[]")
        {
            var count = 0;
            var output = String.Empty;
            
            foreach (var s in connection.Query<string>(sql, param, transaction, buffered, commandTimeout, commandType))
            {
                count++;
                output += s;
            }
            
            if(output == String.Empty)
                output = defaultOutput;

            Console.WriteLine($"Dapper Rows: {count}");

            return JRaw.Parse(output);
        }
    }
}