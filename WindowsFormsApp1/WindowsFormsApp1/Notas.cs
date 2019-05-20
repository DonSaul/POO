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

namespace Presentation
{
    public partial class Notas : Form
    {
        
        CD_Posts ObjetoCD = new CD_Posts();
        private Boolean edit = false;
        string curson = null;
        string Idcont = null;
        string nombrecur = null;
        string periodo = null;
        int ed = 0;

        public Notas(string nombre)
        {
            InitializeComponent();
            this.user = nombre;
        }

        string user;

        /// 
        /// 

        private void Notas_Load(object sender, EventArgs e)
        {

            Chou();
            MessageBox.Show("Seleccione con doble click en el nombre del curso para ver su contenido");

        }
        /// 
        /// 
        string codigo = null;
        //carga el menu de cursos
        private void Chou()
        {
            CD_Posts ObjetoCD2 = new CD_Posts();
            dataGridView2.DataSource = ObjetoCD2.ShowCombo(user);
            this.dataGridView2.Columns["IDcursos"].Visible = false;
            this.dataGridView2.Columns["Codigo"].Visible = false;





        }

        //carga la tabla
       // private void test(){  }
        private void Cargar()
        {

            CD_Posts ObjetoCD3 = new CD_Posts();
            if (codigo != null) {
                dataGridView1.DataSource = ObjetoCD3.ShowPosts(user, codigo);
                this.dataGridView1.Columns["Contenido"].Visible = false;
                this.dataGridView1.Columns["Periodo"].Visible = false;
                this.dataGridView1.Columns["Secreto"].Visible = false;
            }
            else {

                MessageBox.Show("Selecciona un Curso valido");
            }

        }

        

        
      
        private void limpiarform()
        {

            TxtCont.Clear();
            Txttitle.Clear();
        }

      


        private void Doubleclik(object sender, DataGridViewCellEventArgs e)
        {
            codigo = dataGridView2.CurrentRow.Cells["Codigo"].Value.ToString();
            nombrecur= dataGridView2.CurrentRow.Cells["Nombre"].Value.ToString();
            periodo=dataGridView2.CurrentRow.Cells["Periodo"].Value.ToString();
   
            Cargar();
           
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txttitle.Text) && string.IsNullOrEmpty(Txttitle.Text))
            {
                MessageBox.Show("Inserte un titulo valido");

            }
            else
            {
                if (string.IsNullOrWhiteSpace(TxtCont.Text) && string.IsNullOrEmpty(TxtCont.Text))
                {
                    MessageBox.Show("Inserte un contenidovalido");
                }
                else
                {



                    if (edit == false && codigo != null && nombrecur != null)
                    {
                        try
                        {
                            curson = codigo + Txttitle.Text;
                            ObjetoCD.InsertNote(periodo, Txttitle.Text, TxtCont.Text, user, nombrecur, codigo, curson);
                            Cargar();
                           
                            Chou();

                            limpiarform();
                        }
                        catch (Exception ex)
                        {

                        
                            reload();
                   
                            

                        }
                    }

                }
            }

            if (ed == 0)
            {
                if (edit == true && codigo != null && nombrecur != null)
                {
                    ed = 1;

                    if (string.IsNullOrWhiteSpace(Txttitle.Text) && string.IsNullOrEmpty(Txttitle.Text))
                    {
                        MessageBox.Show("Inserte un titulo valido");

                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(TxtCont.Text) && string.IsNullOrEmpty(TxtCont.Text))
                        {
                            MessageBox.Show("Inserte un contenidovalido");
                        }
                        else
                        {

                            try
                            {
                                curson = codigo + Txttitle.Text;
                                ObjetoCD.EditarCon(Txttitle.Text, TxtCont.Text, Idcont, user, nombrecur, codigo, curson);
                                Cargar();
                                ed = 0;
                                MessageBox.Show("Se Actualizó el Campo Correctamente");
                                edit = false;
                                Chou();
                                limpiarform();

                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("error ");
                                reload();
                               

                            }

                        }

                    }
                }
            }
            else {
                main m = new main(user);
               
                m.btnVer.PerformClick();

            }
        }
        private void reload() {
            this.Controls.Clear();
            this.InitializeComponent();
            Chou();
            MessageBox.Show("Seleccione con doble click en el nombre del curso para ver su contenido");
        }

        private void EditBtn_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                edit = true;




             

                codigo = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
                Txttitle.Text = dataGridView1.CurrentRow.Cells["Titulo"].Value.ToString();
                TxtCont.Text = dataGridView1.CurrentRow.Cells["Contenido"].Value.ToString();
                Idcont = dataGridView1.CurrentRow.Cells["IDcontenido"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecciona El Contenido  a Editar");

            }
        }

        private void DeletBtn_Click_1(object sender, EventArgs e)
        {
             if (dataGridView1.SelectedRows.Count > 0)
            {

                Idcont = dataGridView1.CurrentRow.Cells["IDcontenido"].Value.ToString();
                ObjetoCD.EliminarCont(Idcont);
                MessageBox.Show("El post se eliminó Correctamente");
                Chou();
                Cargar();
                limpiarform();

            }
            else
            {
                MessageBox.Show("Selecciona El post  a Eliminar");
            }
        }
    }
}
