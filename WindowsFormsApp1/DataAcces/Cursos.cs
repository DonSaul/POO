using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;
using System.Windows.Forms;

namespace DataAcces
{
   public class Cursos
    {
       private Csql conexion = new Csql();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
     

        public DataTable Show(string user) {
           
            comando.Connection = conexion.opencon();
            comando.CommandText = "ShowProc";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@user", user);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.closecon();
            comando.Parameters.Clear();
            return tabla;
          


        }
       
      
        public void Insertar(string Encargado,string Nombre,string Periodo,string codigo,string secreto) {
            try
            {
                comando.Connection = conexion.opencon();
                comando.CommandText = "Insertar";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Encargado", Encargado);
                comando.Parameters.AddWithValue("@Nombre", Nombre);
                comando.Parameters.AddWithValue("@p", Periodo);
                comando.Parameters.AddWithValue("@code", codigo);
                comando.Parameters.AddWithValue("@secret", secreto);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.closecon();
                MessageBox.Show("El Curso se genero Correctamente");
            }
            catch(Exception ex) {

                comando.Parameters.Clear();
                conexion.closecon();
                MessageBox.Show("No se puede generar un codigo de curso  repetido teclee otro nombre u otro periodo");
                
            }


        }



        public void Edit(string Nombre, string periodo,int IDcursos,string code )
        {

            try
            {
                comando.Connection = conexion.opencon();
                comando.CommandText = "Edit";

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombre", Nombre);
                comando.Parameters.AddWithValue("@p", periodo);
                comando.Parameters.AddWithValue("@code", code);
                comando.Parameters.AddWithValue("@IDcurso", IDcursos);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {

                comando.Parameters.Clear();
                conexion.closecon();
            }

        }
        public void Editc(string Nombre, string p,string code) {
            try { 
            comando.Connection = conexion.opencon();
            comando.CommandText="Editcur";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@p", p);
            comando.Parameters.AddWithValue("@Code", code);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            }
            catch (Exception ex)
            {

                comando.Parameters.Clear();
                conexion.closecon();
            }

        }
        public void delete(int IDcursos) {
            try { 
            comando.Connection = conexion.opencon();
            comando.CommandText = "DeleteC";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDCursos",IDcursos);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            }
            catch (Exception ex)
            {

                comando.Parameters.Clear();
                conexion.closecon();
            }
        }
   }
}
