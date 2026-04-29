using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project
{
    public class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(
                @"Data Source=DESKTOP-EPQ1CDN\SQLEXPRESS;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=""SQL Server Management Studio"";Command Timeout=30");
        }
    }
}
