using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DataAcces;

namespace Domain
{
    public class CD_Cursos
    {
        private Cursos ObjectoCD = new Cursos();
        public DataTable ShowCursos(string user)
        {

            DataTable tabla = new DataTable();
            tabla = new DataTable();
            tabla = ObjectoCD.Show(user);
            return tabla;

        }
        public void InsertarC( string Encargado,string Nombre,string Periodo,string code,string secreto)
        {
            ObjectoCD.Insertar(Encargado, Nombre,Periodo,code,secreto);
        }
        public void EditarC(string Nombre,string periodo ,string IDCursos,string code) {


            ObjectoCD.Edit(Nombre, periodo,Convert.ToInt32(IDCursos),code);
          


        }
        public void EditarN(string Nombre,string periodo ,string code) {

            ObjectoCD.Editc(Nombre,periodo,code);

        }
        public void EliminarC(string IDcursos) {
            ObjectoCD.delete(Convert.ToInt32(IDcursos));


        }
    }
}
