using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;

namespace Presentation
{
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Btnmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        private void btncls_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Text = DateTime.Now.ToShortTimeString();
            fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void mainp_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void abrirfirmhijo(object formhijo)
        {

            if (this.pancontainer.Controls.Count > 0)
            
                this.pancontainer.Controls.RemoveAt(0);
                Form fh = formhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.pancontainer.Controls.Add(fh);
                this.pancontainer.Tag = fh;
                fh.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            abrirfirmhijo(new logo());
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
            pictureBox1_Click(null, e);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas Seguro de Salir", "advertencia",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                Login l = new Login();
                l.Show();


            }
        }

        private void btncursos_Click(object sender, EventArgs e)
        {
            abrirfirmhijo(new cursoalumnos());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://forms.gle/jqquxYLr8Y5SeUHw5");
        }
    }
}
