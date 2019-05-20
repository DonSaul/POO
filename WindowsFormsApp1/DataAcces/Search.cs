using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;

namespace DataAcces
{
    public class Search
    {
        Csql conexion = new Csql();
        SqlDataReader read;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        DataTable table = new DataTable();

        public DataTable Showlbl(string codigo) {

            comando.Connection = conexion.opencon();
            comando.CommandText = "ConsulCod";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod", codigo);
            read = comando.ExecuteReader();
            table.Load(read);
            comando.Parameters.Clear();
            conexion.closecon();
            return (table);
            

        }
        public void suma(string nombre) {

            comando.Connection = conexion.opencon();
            comando.CommandText = "Clickid";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@titulo", nombre);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
         
            conexion.closecon();

        }
        public bool confirmar(string codigo) {
            comando.Connection = conexion.opencon();
            comando.CommandText = "select *from Contenido where Codigo=@codigo";
            comando.Parameters.AddWithValue("@codigo", codigo);
            comando.CommandType = CommandType.Text;
            read = comando.ExecuteReader();

            if (read.HasRows)
            {
                while (read.Read())
                {

                    CodigoCache.IDcursos = read.GetInt32(0);
                    CodigoCache.Codigo = read.GetString(3);
                    
                }
                comando.Parameters.Clear();
                read.Close();
                conexion.closecon();
                return true;
            }
            else
            {
                comando.Parameters.Clear();
                read.Close();
                return false;
            
            }
          

        }

    }
}
