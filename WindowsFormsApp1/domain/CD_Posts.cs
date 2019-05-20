using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAcces;

namespace Domain
{
    public class CD_Posts
    {

        private Posts ObjetoCD = new Posts();

        public DataTable ShowPosts(string user, string nombrecur) {

            DataTable tabla = new DataTable();
            tabla = new DataTable();
            tabla = ObjetoCD.Show(user, nombrecur);
            return tabla;
        }
        public DataTable ShowCombo(string user)
        {

            DataTable tabla2 = new DataTable();
            tabla2 = new DataTable();
            tabla2 = ObjetoCD.LoadCombo(user);
            return tabla2;
        }
        public void InsertNote(string P,string Titulo, string Contenido, string Encargado, string Nombrecur,string codigo,string secreto) {

            ObjetoCD.Insertar(P,Titulo, Contenido, Encargado, Nombrecur,codigo,secreto);


        }
        public void EditarCon(string Titulo, string Cont, string Idcont, string Encargado, string Nombrecur, string codigo, string secreto) {
           
            ObjetoCD.Editar(Titulo, Cont, Convert.ToInt32(Idcont),Encargado,Nombrecur,codigo,secreto);

        }
        public void EliminarCont(string Idcont) {

            ObjetoCD.delete(Convert.ToInt32(Idcont));


        }
    }
}
