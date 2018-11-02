using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ejercicio60
{
    class SqlConexion
    {
        private SqlConnection conexion;
        public SqlConexion(string source, string nombre)
        {
            string conexionStr = "Data Source=[" + source + "];Initial Catalog=[" + nombre + "];Integrated Security=True";
            conexion = new SqlConnection(conexionStr);
        }
    }
}
