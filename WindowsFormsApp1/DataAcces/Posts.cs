using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAcces
{
    public class Posts
    {
        private Csql conexion = new Csql();
        SqlDataReader read;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        DataTable table = new DataTable();

        public DataTable LoadCombo(string user) {
            comando.Connection = conexion.opencon();
            comando.CommandText = "loadcombo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@user", user);
            read = comando.ExecuteReader();
            
            table.Load(read);
            comando.Parameters.Clear();
            conexion.closecon();
            return (table);

        }

        public DataTable Show(string user,string nombrecur) {

            comando.Connection = conexion.opencon();
            comando.CommandText = "ShowConttitle";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@user", user);
            comando.Parameters.AddWithValue("@cursoname", nombrecur);
            read = comando.ExecuteReader();
            tabla.Load(read);
            conexion.closecon();
            comando.Parameters.Clear();
            return tabla;


        }
        public void Insertar(string P ,string Titulo, string Contenido,string Encargado,string Nombrecur,string codigo, string secreto) {


          try{
            comando.Connection= conexion.opencon();
            comando.CommandText = "InsertarC";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@P", P);
            comando.Parameters.AddWithValue("@Titulo", Titulo);
            comando.Parameters.AddWithValue("@Contenido", Contenido);
            comando.Parameters.AddWithValue("@Encargado", Encargado);
            comando.Parameters.AddWithValue("@Nombre", Nombrecur);
            comando.Parameters.AddWithValue("@codigo", codigo);
            comando.Parameters.AddWithValue("@secret", secreto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.closecon();
                MessageBox.Show("El Post se creó correctamente");
            }
            catch (Exception ex)
            {

                comando.Parameters.Clear();
                conexion.closecon();
                MessageBox.Show("El Titulo de Post ya existe");

            }


        }
        public void Editar( string Titulo, string Cont, int Idcont,string Encargado, string Nombrecur, string codigo, string secreto) {
            try { 
            comando.Connection = conexion.opencon();
            comando.CommandText = "EditCon";
            comando.CommandType = CommandType.StoredProcedure;
           
            comando.Parameters.AddWithValue("@Titulo",Titulo);
            comando.Parameters.AddWithValue("@Cont",Cont);
            comando.Parameters.AddWithValue("@Id",Idcont);
            comando.Parameters.AddWithValue("@Encargado",Encargado);
            comando.Parameters.AddWithValue("@Nombre",Nombrecur);
            comando.Parameters.AddWithValue("@codigo", codigo);
            comando.Parameters.AddWithValue("@secret", secreto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.closecon();

            }
            catch (Exception ex)
            {

                comando.Parameters.Clear();
                conexion.closecon();
            }

        }
        public void delete(int Idcont)
        {
            try
            {
                comando.Connection = conexion.opencon();
                comando.CommandText = "DeleteCont";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id", Idcont);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.closecon();
            }
            catch (Exception ex)
            {

                comando.Parameters.Clear();
                conexion.closecon();
            }
        }


    }
}
