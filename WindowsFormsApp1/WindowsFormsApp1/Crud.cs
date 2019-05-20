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
    public partial class Crud : Form
    {
        CD_CRUD ObjetoCD = new CD_CRUD();
        private Boolean edit = false;
        string curson = null;
        string usuario = null;

        public Crud()
        {
            InitializeComponent();
        }
        private void Cargar()
        {
            CD_CRUD ObjetoCD2 = new CD_CRUD();
            dataGridView1.DataSource = ObjetoCD2.Showusers();


        }


        private void Crud_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {
                if (string.IsNullOrWhiteSpace(Txtus.Text) && string.IsNullOrEmpty(Txtus.Text))
            {
                MessageBox.Show("Inserte un titulo valido");

            }
            else
            {
                if (string.IsNullOrWhiteSpace(Txtpas.Text) && string.IsNullOrEmpty(Txtpas.Text))
                {
                    MessageBox.Show("Inserte un contenidovalido");
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(Txtnom.Text) && string.IsNullOrEmpty(Txtnom.Text))
                    {
                        MessageBox.Show("Inserte un titulo valido");

                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(Txtap.Text) && string.IsNullOrEmpty(Txtap.Text))
                        {
                            MessageBox.Show("Inserte un contenidovalido");
                        }
                        else
                        {

                            try
                            {
                                ObjetoCD.InsertarC(Txtus.Text, Txtpas.Text, Txtnom.Text, Txtap.Text);
                                Cargar();
                                limpiarform();


                            }
                            catch (Exception ex)
                            {
                                Cargar();
                                limpiarform();



                            }

                        }
                    }
                }
            }
        }
    
            /* 


                     
*/
            if (edit == true && curson != null && usuario != "admin")
            {
                if (string.IsNullOrWhiteSpace(Txtus.Text) && string.IsNullOrEmpty(Txtus.Text) )
                {
                    MessageBox.Show("Inserte un nombre de usuario  valido");

                }
                else
                {
                    if (string.IsNullOrWhiteSpace(Txtpas.Text) && string.IsNullOrEmpty(Txtpas.Text))
                    {
                        MessageBox.Show("Inserte una contraseña valida");
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(Txtnom.Text) && string.IsNullOrEmpty(Txtnom.Text))
                        {
                            MessageBox.Show("Inserte un nombre valido");

                        }
                        else
                        {
                            if (string.IsNullOrWhiteSpace(Txtap.Text) && string.IsNullOrEmpty(Txtap.Text))
                            {
                                MessageBox.Show("Inserte un apellido");
                            }
                            else
                            {
                                try
                                {
                                    ObjetoCD.EditarC(curson, Txtus.Text, Txtpas.Text, Txtnom.Text, Txtap.Text);
                                    Cargar();
                                    limpiarform();
                                    MessageBox.Show("El Usuario se editó correctamente ");
                                    edit = false;
                                }
                                catch (Exception ex)
                                {
                                    Cargar();
                                    limpiarform();
                                    MessageBox.Show("El nombre de usuario ya esta en uso");
                                }
                            }

                        }
                        
                    }
                }


            }
            else
            {
                try
                {
                    ObjetoCD.EditarC(curson, usuario, Txtpas.Text, Txtnom.Text, Txtap.Text);
                    Cargar();
                    limpiarform();
                   
                    edit = false;
                    MessageBox.Show("El Usuario administrador editó correctamente ");
                }
                catch (Exception ex)
                {
                    Cargar();
                    limpiarform();
                  
                    edit = false;
                }
            }
        }

        private void limpiarform() {

            Txtus.Clear();
            Txtpas.Clear();
            Txtnom.Clear();
            Txtap.Clear();
                

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                edit = true;
             

                curson = dataGridView1.CurrentRow.Cells["UserID"].Value.ToString();
                
                usuario = dataGridView1.CurrentRow.Cells["Lname"].Value.ToString();
                if (usuario == "admin")
                {
                    MessageBox.Show("El usuario administrador no  puede cambiar de nombre de usuario");
                    Txtpas.Text = dataGridView1.CurrentRow.Cells["Password"].Value.ToString();
                    Txtnom.Text = dataGridView1.CurrentRow.Cells["Fname"].Value.ToString();
                    Txtap.Text = dataGridView1.CurrentRow.Cells["Laname"].Value.ToString();
                }
                else {
                    Txtus.Text = dataGridView1.CurrentRow.Cells["Lname"].Value.ToString();
                    Txtpas.Text = dataGridView1.CurrentRow.Cells["Password"].Value.ToString();
                    Txtnom.Text = dataGridView1.CurrentRow.Cells["Fname"].Value.ToString();
                    Txtap.Text = dataGridView1.CurrentRow.Cells["Laname"].Value.ToString();


                }
            }

        }

        private void button3_Click(object sender, EventArgs e)

        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                curson = dataGridView1.CurrentRow.Cells["UserID"].Value.ToString();
                if (curson != "1")
                {
                    ObjetoCD.EliminarC(curson);

                    MessageBox.Show("El usuario se eliminó Correctamente");
                    Cargar();
                    limpiarform();

                }
                else {

                    MessageBox.Show("El usuario administrador no  se puede eliminar");

                }
            }
            else
            {
                MessageBox.Show("Selecciona El Curso  a Eliminar");
            }
            
        }

        
    }
}
