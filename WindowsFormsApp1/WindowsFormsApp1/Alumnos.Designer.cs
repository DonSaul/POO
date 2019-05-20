namespace Presentation
{
    partial class Alumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alumnos));
            this.mainp = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.btncls = new System.Windows.Forms.PictureBox();
            this.Btnmini = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btncursos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pancontainer = new System.Windows.Forms.TableLayoutPanel();
            this.mainp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnmini)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainp
            // 
            this.mainp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mainp.Controls.Add(this.panel1);
            this.mainp.Controls.Add(this.timer);
            this.mainp.Controls.Add(this.fecha);
            this.mainp.Controls.Add(this.btncls);
            this.mainp.Controls.Add(this.Btnmini);
            this.mainp.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainp.Location = new System.Drawing.Point(0, 0);
            this.mainp.Name = "mainp";
            this.mainp.Size = new System.Drawing.Size(892, 48);
            this.mainp.TabIndex = 20;
            this.mainp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainp_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(159, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 413);
            this.panel1.TabIndex = 22;
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.ForeColor = System.Drawing.Color.White;
            this.timer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.timer.Location = new System.Drawing.Point(279, 9);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(102, 36);
            this.timer.TabIndex = 11;
            this.timer.Text = "label1";
            // 
            // fecha
            // 
            this.fecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.ForeColor = System.Drawing.Color.White;
            this.fecha.Location = new System.Drawing.Point(445, 9);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(102, 36);
            this.fecha.TabIndex = 10;
            this.fecha.Text = "label1";
            // 
            // btncls
            // 
            this.btncls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncls.Image = global::WindowsFormsApp1.Properties.Resources.icons8_multiply_64;
            this.btncls.Location = new System.Drawing.Point(853, 3);
            this.btncls.Name = "btncls";
            this.btncls.Size = new System.Drawing.Size(31, 42);
            this.btncls.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncls.TabIndex = 9;
            this.btncls.TabStop = false;
            this.btncls.Click += new System.EventHandler(this.btncls_Click);
            // 
            // Btnmini
            // 
            this.Btnmini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnmini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnmini.Image = global::WindowsFormsApp1.Properties.Resources.minimizar;
            this.Btnmini.Location = new System.Drawing.Point(816, 3);
            this.Btnmini.Name = "Btnmini";
            this.Btnmini.Size = new System.Drawing.Size(31, 42);
            this.Btnmini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btnmini.TabIndex = 8;
            this.Btnmini.TabStop = false;
            this.Btnmini.Click += new System.EventHandler(this.Btnmini_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.panel.Controls.Add(this.panel3);
            this.panel.Controls.Add(this.button1);
            this.panel.Controls.Add(this.pictureBox2);
            this.panel.Controls.Add(this.btncursos);
            this.panel.Controls.Add(this.panel2);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 48);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(162, 416);
            this.panel.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel3.Location = new System.Drawing.Point(0, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 52);
            this.panel3.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.idea__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "       Comentarios";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 337);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btncursos
            // 
            this.btncursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.btncursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncursos.FlatAppearance.BorderSize = 0;
            this.btncursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btncursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncursos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncursos.ForeColor = System.Drawing.Color.White;
            this.btncursos.Image = ((System.Drawing.Image)(resources.GetObject("btncursos.Image")));
            this.btncursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncursos.Location = new System.Drawing.Point(15, 87);
            this.btncursos.Name = "btncursos";
            this.btncursos.Size = new System.Drawing.Size(147, 52);
            this.btncursos.TabIndex = 5;
            this.btncursos.Text = "       Cursos";
            this.btncursos.UseVisualStyleBackColor = false;
            this.btncursos.Click += new System.EventHandler(this.btncursos_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(14, 52);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.big_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pancontainer
            // 
            this.pancontainer.ColumnCount = 1;
            this.pancontainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pancontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pancontainer.Location = new System.Drawing.Point(162, 48);
            this.pancontainer.Name = "pancontainer";
            this.pancontainer.RowCount = 1;
            this.pancontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pancontainer.Size = new System.Drawing.Size(730, 416);
            this.pancontainer.TabIndex = 0;
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 464);
            this.Controls.Add(this.pancontainer);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.mainp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alumnos";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.Alumnos_Load);
            this.mainp.ResumeLayout(false);
            this.mainp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnmini)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainp;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.PictureBox btncls;
        private System.Windows.Forms.PictureBox Btnmini;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btncursos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel pancontainer;
    }
}