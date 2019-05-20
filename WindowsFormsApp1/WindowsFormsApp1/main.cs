using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Common.Cache;
using System.Diagnostics;

namespace Presentation
{
    public partial class main : Form
    {
        public main(string nombre)
        {
            InitializeComponent();
            this.nombre = nombre;
        }
        string nombre;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
       
        private void btncls_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
       
     
        

        private void mainp_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas Seguro de Cerrar Sesión", "advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes){
                this.Close();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Text = DateTime.Now.ToShortTimeString();
            fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void fecha_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timer_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void alm_Click(object sender, EventArgs e)
        {
            submenu.Visible = false;
        }
        private void LoadUser() {
            lblname.Text = UserLoginCache.Fname;
        }
        //LOAD
        private void main_Load(object sender, EventArgs e)
        {
            LoadUser();
            pictureBox1_Click(null, e);
            validacion();


        }
        //LOAD
        private void btncursos_Click(object sender, EventArgs e)
        {
            submenu.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirfirmhijo(new Charts(nombre));
        }
         
        private void abrirfirmhijo(object formhijo) {

            if (this.pancontainer.Controls.Count > 0) 

                this.pancontainer.Controls.RemoveAt(0);
                Form fh = formhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.pancontainer.Controls.Add(fh);
                this.pancontainer.Tag = fh;
                fh.Show();
            

        }

        public void crear_Click(object sender, EventArgs e)
        {
            
            abrirfirmhijo(new curse(nombre));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            abrirfirmhijo(new logo());
        }

        public void btnVer_Click(object sender, EventArgs e)
        {
            abrirfirmhijo(new Notas(nombre));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://forms.gle/jqquxYLr8Y5SeUHw5");
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            abrirfirmhijo(new Crud());
        }

        private void validacion() {

            if (nombre == "admin"||nombre=="ADMIN")
            { button1.Visible = true;
                panel7.Visible = true;
            }
            else
            { button1.Visible = false;
                panel7.Visible = false;
            }

        }

       
    }
}
