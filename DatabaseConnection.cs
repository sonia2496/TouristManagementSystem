using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristManagement
{
    internal class DatabaseConnection
    {
        //Establishing connection and setting up database
        private static DatabaseConnection _instance;
        private static readonly object _lock = new object();
        private readonly string _connectionString = "User Id=N01662302;Password=oracle;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=calvin.humber.ca)(PORT=1521))(CONNECT_DATA=(SID=grok)));Connection Timeout=30;";

        private DatabaseConnection() { }

        public static DatabaseConnection Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DatabaseConnection();
                    }
                    return _instance;
                }
            }
        }

        public OracleConnection CreateConnection()
        {
            return new OracleConnection(_connectionString);
        }
    }
}
