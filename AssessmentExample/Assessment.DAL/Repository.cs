﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Assessment.DAL
{
    public class Repository
    {
        private string connectionString;

        public Repository()
        {
            connectionString = @"Data Source=logolsdb.database.windows.net;Initial Catalog=LogolsLearning;Persist Security Info=True;User ID=;Password=";
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }
    }
}
