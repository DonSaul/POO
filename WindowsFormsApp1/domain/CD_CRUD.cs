using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAcces;

namespace Domain
{
    public  class CD_CRUD
    {
        private Crud ObjectoCD = new Crud();

        public DataTable Showusers()
        {

            DataTable tabla = new DataTable();
            tabla = new DataTable();
            tabla = ObjectoCD.Usuarios();
            return tabla;

        }
        public void InsertarC(string Lname, string Password, string Fname, string Laname)
        {
            ObjectoCD.Insertar(Lname, Password, Fname, Laname);
        }

        public void EditarC(string id,string Lname, string Password, string Fname, string Laname)
        {


            ObjectoCD.Edit(Convert.ToInt32(id),Lname, Password, Fname, Laname);



        }
        public void EliminarC(string IDuser)
        {
            ObjectoCD.delete(Convert.ToInt32(IDuser));


        }

    }
}
