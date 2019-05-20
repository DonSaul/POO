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
    public class Crud
    {
        Csql conexion = new Csql();
        SqlDataReader read;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        DataTable table = new DataTable();
        public DataTable Usuarios()
        {
        
            comando.Connection = conexion.opencon();
            comando.CommandText = "showusers";
            comando.CommandType = CommandType.StoredProcedure;
            read = comando.ExecuteReader();
            table.Load(read);
            comando.Parameters.Clear();
            conexion.closecon();
            return (table);
          

        }
        public void Insertar(string Lname,string Password, string Fname,string Laname )
        {
            try { 
            comando.Connection = conexion.opencon();
            comando.CommandText = "Insertarusers";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", Lname);
            comando.Parameters.AddWithValue("@pass", Password);
            comando.Parameters.AddWithValue("@fname", Fname);
            comando.Parameters.AddWithValue("@laname", Laname);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.closecon();
                MessageBox.Show("El Usuario se creó correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Usuario  ya existe");
                comando.Parameters.Clear();
                conexion.closecon();
            }



        }
        public void Edit(int Iduser, string Lname, string Password, string Fname, string Laname)
        {
            try
            {
                comando.Connection = conexion.opencon();
                comando.CommandText = "Editusers";

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", Iduser);
                comando.Parameters.AddWithValue("@nombre", Lname);
                comando.Parameters.AddWithValue("@pass", Password);
                comando.Parameters.AddWithValue("@fname", Fname);
                comando.Parameters.AddWithValue("@laname", Laname);
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
        public void delete(int IDusers)
        {
            try { 
            comando.Connection = conexion.opencon();
            comando.CommandText = "Deleteusers";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", IDusers);
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
    

