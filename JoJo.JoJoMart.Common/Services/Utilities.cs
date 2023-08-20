using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoJo.JoJoMart.Common.Services
{
    public class Utilities : IUtilities
    {
        private readonly IConfiguration configuration;
        public Utilities(
            IConfiguration configuration
            )
        {
            this.configuration = configuration;
        }

        public SqlConnection GetDbConnection()
        {
            SqlConnection dbConnection;
            var connectionString = "Server=JOJO\\MSSQLSERVER01;Database=jojo-mart;Integrated Security=true;";
           // var connectionString = this.configuration.GetConnectionString("clientDb");

            return new SqlConnection(connectionString);
        }
    }
}                                                      