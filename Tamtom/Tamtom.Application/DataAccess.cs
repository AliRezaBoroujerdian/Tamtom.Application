using System;
using System.Collections.Generic;
using System.Text;

namespace Tamtom.Application
{
    public static class DataAccess
    {
        public static string ConnectionString { get; private set; }

        /// <summary>
        /// Initialize connection string
        /// </summary>
        /// <param name="server">locol host, dot, 198.125.125.125, ...</param>
        /// <param name="database">your database name</param>
        /// <param name="user">database user id</param>
        /// <param name="password">user password</param>
        public static void Initialize(string server, string database, string user, string password)
        {
            ConnectionString = $"Server={server};Database={database};User Id={user};Password={password};";
        }

    }
}
