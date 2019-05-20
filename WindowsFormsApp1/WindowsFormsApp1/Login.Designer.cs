namespace Presentation
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtusr = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlgn = new System.Windows.Forms.Button();
            this.Balumno = new System.Windows.Forms.Button();
            this.Talumno = new System.Windows.Forms.ToolTip(this.components);
            this.ErrLbl = new System.Windows.Forms.Label();
            this.btncls = new System.Windows.Forms.PictureBox();
            this.btnmin = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 301);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.big_logo1;
            this.pictureBox3.Location = new System.Drawing.Point(34, 53);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(195, 144);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(744, 301);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.BorderWidth = 3;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 375;
            this.lineShape2.X2 = 661;
            this.lineShape2.Y1 = 173;
            this.lineShape2.Y2 = 173;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.BorderWidth = 3;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 375;
            this.lineShape1.X2 = 661;
            this.lineShape1.Y1 = 89;
            this.lineShape1.Y2 = 89;
            // 
            // txtusr
            // 
            this.txtusr.BackColor = System.Drawing.SystemColors.Control;
            this.txtusr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusr.ForeColor = System.Drawing.Color.Black;
            this.txtusr.Location = new System.Drawing.Point(375, 61);
            this.txtusr.Name = "txtusr";
            this.txtusr.Size = new System.Drawing.Size(287, 20);
            this.txtusr.TabIndex = 1;
            this.txtusr.Text = "USUARIO";
            this.txtusr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtusr.Enter += new System.EventHandler(this.txtusr_Enter);
            this.txtusr.Leave += new System.EventHandler(this.txtusr_Leave);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.SystemColors.Control;
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.Black;
            this.txtpass.Location = new System.Drawing.Point(376, 141);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(287, 20);
            this.txtpass.TabIndex = 2;
            this.txtpass.Text = "CONTRASEÑA";
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(369, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            // 
            // btnlgn
            // 
            this.btnlgn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnlgn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnlgn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlgn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlgn.ForeColor = System.Drawing.Color.White;
            this.btnlgn.Location = new System.Drawing.Point(375, 232);
            this.btnlgn.Name = "btnlgn";
            this.btnlgn.Size = new System.Drawing.Size(123, 40);
            this.btnlgn.TabIndex = 3;
            this.btnlgn.Text = "INICIAR SESIÓN ";
            this.btnlgn.UseVisualStyleBackColor = false;
            this.btnlgn.Click += new System.EventHandler(this.btnlgn_Click);
            // 
            // Balumno
            // 
            this.Balumno.AutoSize = true;
            this.Balumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.Balumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Balumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Balumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Balumno.ForeColor = System.Drawing.Color.White;
            this.Balumno.Location = new System.Drawing.Point(540, 232);
            this.Balumno.Name = "Balumno";
            this.Balumno.Size = new System.Drawing.Size(123, 40);
            this.Balumno.TabIndex = 9;
            this.Balumno.Text = "ALUMNO";
            this.Balumno.UseVisualStyleBackColor = false;
            this.Balumno.Click += new System.EventHandler(this.Balumno_Click);
            this.Balumno.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // ErrLbl
            // 
            this.ErrLbl.AutoSize = true;
            this.ErrLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrLbl.ForeColor = System.Drawing.Color.Black;
            this.ErrLbl.Image = global::WindowsFormsApp1.Properties.Resources.advertencia__1_;
            this.ErrLbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ErrLbl.Location = new System.Drawing.Point(372, 192);
            this.ErrLbl.Name = "ErrLbl";
            this.ErrLbl.Size = new System.Drawing.Size(44, 21);
            this.ErrLbl.TabIndex = 8;
            this.ErrLbl.Text = "Error";
            this.ErrLbl.Visible = false;
            // 
            // btncls
            // 
            this.btncls.Image = global::WindowsFormsApp1.Properties.Resources.icons8_multiply_64;
            this.btncls.Location = new System.Drawing.Point(698, 0);
            this.btncls.Name = "btncls";
            this.btncls.Size = new System.Drawing.Size(31, 42);
            this.btncls.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncls.TabIndex = 7;
            this.btncls.TabStop = false;
            this.btncls.Click += new System.EventHandler(this.btncls_Click);
            // 
            // btnmin
            // 
            this.btnmin.Image = global::WindowsFormsApp1.Properties.Resources.minimizar;
            this.btnmin.Location = new System.Drawing.Point(661, 0);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(31, 42);
            this.btnmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmin.TabIndex = 6;
            this.btnmin.TabStop = false;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(744, 301);
            this.Controls.Add(this.Balumno);
            this.Controls.Add(this.ErrLbl);
            this.Controls.Add(this.btncls);
            this.Controls.Add(this.btnmin);
            this.Controls.Add(this.btnlgn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusr);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txtusr;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlgn;
        private System.Windows.Forms.PictureBox btnmin;
        private System.Windows.Forms.PictureBox btncls;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label ErrLbl;
        private System.Windows.Forms.Button Balumno;
        private System.Windows.Forms.ToolTip Talumno;
    }
}

