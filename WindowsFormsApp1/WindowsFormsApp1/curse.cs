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
using Common.Cache;


namespace Presentation
{
    public partial class curse : Form
    {
      string IDCurson = null;
        private Boolean edit = false;
        private CD_Cursos ObjetoCD = new CD_Cursos();
      
        public curse(string nombre)
        {


            InitializeComponent();
            this.user = nombre;

        }


        private void reload()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            ShowCursos();

        }

        string user;
        
     
        private void ShowCursos()
        {
            CD_Cursos ObjetoCD2 = new CD_Cursos();
          
            dataGridView1.DataSource = ObjetoCD2.ShowCursos(user);


        }
        string secreto = null;
        string codigo = null;
        private void button1_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {
                try
                {
                  
                    if (txtcurson.Text != "")
                    {
                        if (TxtPerio.Text != "")
                        {
                            codigo = user + txtcurson.Text + TxtPerio.Text;
                            secreto = user + txtcurson.Text + TxtPerio.Text + "Titulo ejemplo";
                            if (secreto != null && codigo != null)
                            {
                                ObjetoCD.InsertarC(user, txtcurson.Text, TxtPerio.Text, codigo, secreto);
                        
                                ShowCursos();
                                limpiarform();
                            }
                        }
                        else {
                            MessageBox.Show("El periodo del curso no es valido");
                        }
                    }
                    else {
                        MessageBox.Show("El nombre del curso no es valido");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El codigio de curso actual ya esta en uso");
                    reload();

                }
            }
            if (edit == true) {

                try
                {

                 

                    if (txtcurson.Text != "")
                    {
                        if (TxtPerio.Text != "")
                        {
                            codigo = user + txtcurson.Text + TxtPerio.Text;
                            ObjetoCD.EditarC(txtcurson.Text, TxtPerio.Text,IDCurson, codigo);
                            ObjetoCD.EditarN(txtcurson.Text, TxtPerio.Text, codigo);
                            MessageBox.Show("Se Actualizó el Campo Correctamente y el nuevo codigo es: " + codigo);
                            edit = false;
                            ShowCursos();
                            limpiarform();
                        }
                        else {
                            ShowCursos();
                            MessageBox.Show("El periodo del curso no es valido");
                            reload();
                        }
                    }
                    else {
                        ShowCursos();
                        MessageBox.Show("El nombre del curso no es valido");
                        reload();
                    }
                }
                catch (Exception ex)
                {
                    ShowCursos();
                    MessageBox.Show("El codigio de curso actual ya esta en uso");
                    reload();

                }
                 

            }
        }
      
        //LOAD
        private void curse_Load(object sender, EventArgs e)
        {
            ShowCursos();
           
            
        }
        //LOAD
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                edit = true;
                
                txtcurson.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                TxtPerio.Text= dataGridView1.CurrentRow.Cells["Periodo"].Value.ToString();
                IDCurson = dataGridView1.CurrentRow.Cells["IDcursos"].Value.ToString();

            }
            else
            { 
            }

            
        }
        private void limpiarform()
        {

         
            txtcurson.Clear();
            TxtPerio.Clear();
          

        }

        private void DeletBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                IDCurson = dataGridView1.CurrentRow.Cells["IDcursos"].Value.ToString();
                ObjetoCD.EliminarC(IDCurson);
                MessageBox.Show("El Curso se eliminó Correctamente");
                ShowCursos();
                limpiarform();

            }
            else
            {
                MessageBox.Show("Selecciona El Curso  a Eliminar");
            }

        }
    }
}

