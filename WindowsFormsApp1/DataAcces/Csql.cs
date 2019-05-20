using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAcces
{
    public class Csql
    {
        private readonly string ca;
        public Csql() {
            ca = "server= SAUL-PC; Database= kklab; Integrated security= true";

        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(ca);
        }


        private SqlConnection Conexion = new SqlConnection("server= SAUL-PC; Database= kklab; Integrated security= true");
        public SqlConnection opencon() {

            if (Conexion.State == ConnectionState.Closed) {
                Conexion.Open();
            }
            return Conexion;
        }

        public SqlConnection closecon() {

            if (Conexion.State == ConnectionState.Open) {

                Conexion.Close();
            }
            return Conexion;
        }
    }
}
