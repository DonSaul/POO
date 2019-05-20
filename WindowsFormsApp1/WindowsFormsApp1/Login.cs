
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
using Domain;


namespace Presentation
{
    public partial class Login : Form
    {
       public string nombre;
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusr_Enter(object sender, EventArgs e)
        {
            if(txtusr.Text == "USUARIO")
            {

                txtusr.Text = "";
                txtusr.ForeColor = Color.Black;

            }
        }

        private void txtusr_Leave(object sender, EventArgs e)
        {
            if (txtusr.Text == "")
            {
                txtusr.Text = "USUARIO";
                txtusr.ForeColor = Color.Black;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {

                txtpass.Text = "";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = true;


            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btncls_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnlgn_Click(object sender, EventArgs e)
        {
            if (txtusr.Text != "USUARIO")
            {
                if (txtpass.Text != "CONTRASEÑA") {
                   
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtusr.Text, txtpass.Text);
                    if (validLogin == true)
                    {
                        nombre = txtusr.Text;
                        main main = new main(nombre);
                      
                        
                        main.Show();
                        main.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        msgerr("El Usuario o La Contraseña No son Validos");
                        txtpass.Text = "CONTRASEÑA";
                        txtusr.Text = "USUARIO";
                        txtusr.Focus();
                    }
                }
                else msgerr("Ingresa Una Contraseña Valida");
            }
            else msgerr("Ingresa Un nombre de Usuario");

            
            
        }
        private void msgerr(string msg) {

            ErrLbl.Text = "      " + msg;
            ErrLbl.Visible = true;

        }
        private void Logout(object sender,FormClosedEventArgs e ) {


            txtpass.Text = "CONTRASEÑA";
            txtpass.UseSystemPasswordChar = false;
            txtusr.Text = "USUARIO";
            txtusr.UseSystemPasswordChar = false;
            ErrLbl.Visible = false;
            this.Show();
          
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Talumno.SetToolTip(Balumno, "Inicia Sesión como Alumno (Anonimo)");
        }

        private void Balumno_Click(object sender, EventArgs e)
        {
            Alumnos alumnos = new Alumnos();
            alumnos.Show();
            this.Hide();
        }
    }
}
