using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAcces;


namespace Domain
{
    public class CD_Search
    {
        private Search ObjetoCD = new Search();

        public DataTable Showlbl(string cod) {

            DataTable tabla = new DataTable();
            tabla = new DataTable();
            tabla = ObjetoCD.Showlbl(cod);
            return tabla;

        }

        public void suma(string titulo)
        {
            ObjetoCD.suma(titulo);

        }
        public bool  Confirmarc(string codigo) {

            return ObjetoCD.confirmar(codigo); 
        }

    }
}
