using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Domain;



namespace Presentation
{
    public partial class cursoalumnos : Form
    {
        CD_Search ObjetoCD = new CD_Search();

        public cursoalumnos()
        {
            InitializeComponent();
        }
        string codigo = null;



        private void Buscar_Click(object sender, EventArgs e)
        {
                cargar();
            

        }


        private void limpiarform() {
            Txttitulo.Clear();
            TxtRich.Clear();

        }
        private void cargar()
        {

            codigo = Codtxt.Text;
            if (codigo != "")
            {
                var con = ObjetoCD.Confirmarc(codigo);
                if (con == true)
                {
                    CD_Search ObjetoCD2 = new CD_Search();
                    dataGridView1.DataSource = ObjetoCD2.Showlbl(codigo);

                    this.dataGridView1.Columns["Contenido"].Visible = false;
                    this.dataGridView1.Columns["IDcontenido"].Visible = false;
                    this.dataGridView1.Columns["Secreto"].Visible = false;
                    limpiarform();
                    MessageBox.Show("Selecciona con doble click el titulo para mostrar el contenido");

                }
                else
                {

                    msgerr("El codigo no es valido");
                    Clearf();
                    Codtxt.Focus();


                }


            }
            else {
                msgerr("El codigo esta vacio");

                Codtxt.Focus();

            }
        }
        private void Clearf() {

            Codtxt.Clear();

        }
        private void msgerr(string msg)
        {

            ErrLbl.Text = "      " + msg;
            ErrLbl.Visible = true;

        }
        /*
        private void test() {

            label5.Text = cont;

        }
        */
        private void cursoalumnos_Load(object sender, EventArgs e)
        {
         

        }
        string cont= null;
        
    

        private void Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                Txttitulo.Text = dataGridView1.CurrentRow.Cells["Titulo"].Value.ToString();
                TxtRich.Text = dataGridView1.CurrentRow.Cells["Contenido"].Value.ToString();
                cont = dataGridView1.CurrentRow.Cells["Secreto"].Value.ToString();
                if (cont != null)
                {

                    ObjetoCD.suma(cont);

                }
            }
            else
            {
                MessageBox.Show("Selecciona El Contenido a ver");


            }

        }
    }
}
