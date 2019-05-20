using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using LiveCharts;
using LiveCharts.Wpf;



namespace Presentation
{
    public partial class Charts : Form
    {
       
        CD_Posts ObjetoCD = new CD_Posts();
        public Charts(string nombre)
        {
            InitializeComponent();
            this.user = nombre;
        }
        string user;

        
       
        private void Charts_Load(object sender, EventArgs e)
        {

          
        }
        string curso = null;
        private void Chou()
        {
            
   

    


        }

     

        private void VER_Click(object sender, EventArgs e)
        {

        }

       
    }
}
