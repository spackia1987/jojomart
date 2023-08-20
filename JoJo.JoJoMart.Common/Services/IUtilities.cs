using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoJo.JoJoMart.Common.Services
{
    public interface IUtilities
    {
        SqlConnection GetDbConnection();
    }
}
