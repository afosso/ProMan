namespace ProMan
{
    partial class FrmPrincipal
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
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.PanelColaboradores = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.PanelTareas = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.PanelProyectos = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.PanelInicio = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TxtNombreApp = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMaximize = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.BtnMinimize = new System.Windows.Forms.PictureBox();
            this.BtnMenu = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            this.PanelColaboradores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.PanelTareas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PanelProyectos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(79)))), ((int)(((byte)(133)))));
            this.PanelMenu.Controls.Add(this.PanelColaboradores);
            this.PanelMenu.Controls.Add(this.PanelTareas);
            this.PanelMenu.Controls.Add(this.PanelProyectos);
            this.PanelMenu.Controls.Add(this.PanelInicio);
            this.PanelMenu.Controls.Add(this.TxtNombreApp);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(200, 555);
            this.PanelMenu.TabIndex = 0;
            // 
            // PanelColaboradores
            // 
            this.PanelColaboradores.Controls.Add(this.label4);
            this.PanelColaboradores.Controls.Add(this.pictureBox3);
            this.PanelColaboradores.Controls.Add(this.panel10);
            this.PanelColaboradores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelColaboradores.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelColaboradores.Location = new System.Drawing.Point(0, 200);
            this.PanelColaboradores.Name = "PanelColaboradores";
            this.PanelColaboradores.Size = new System.Drawing.Size(200, 50);
            this.PanelColaboradores.TabIndex = 5;
            this.PanelColaboradores.Click += new System.EventHandler(this.AbrirFormulario_Click);
            this.PanelColaboradores.MouseLeave += new System.EventHandler(this.CambiarColorPanel_MouseLeave);
            this.PanelColaboradores.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CambiarColorPanel_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Colaboradores";
            this.label4.Click += new System.EventHandler(this.AbrirFormulario_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProMan.Properties.Resources.collaborators;
            this.pictureBox3.Location = new System.Drawing.Point(15, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.AbrirFormulario_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(79)))), ((int)(((byte)(133)))));
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 50);
            this.panel10.TabIndex = 0;
            // 
            // PanelTareas
            // 
            this.PanelTareas.Controls.Add(this.label3);
            this.PanelTareas.Controls.Add(this.pictureBox2);
            this.PanelTareas.Controls.Add(this.panel8);
            this.PanelTareas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTareas.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTareas.Location = new System.Drawing.Point(0, 150);
            this.PanelTareas.Name = "PanelTareas";
            this.PanelTareas.Size = new System.Drawing.Size(200, 50);
            this.PanelTareas.TabIndex = 4;
            this.PanelTareas.Click += new System.EventHandler(this.AbrirFormulario_Click);
            this.PanelTareas.MouseLeave += new System.EventHandler(this.CambiarColorPanel_MouseLeave);
            this.PanelTareas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CambiarColorPanel_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(53, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tareas";
            this.label3.Click += new System.EventHandler(this.AbrirFormulario_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProMan.Properties.Resources.task;
            this.pictureBox2.Location = new System.Drawing.Point(15, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.AbrirFormulario_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(79)))), ((int)(((byte)(133)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 50);
            this.panel8.TabIndex = 0;
            // 
            // PanelProyectos
            // 
            this.PanelProyectos.Controls.Add(this.label2);
            this.PanelProyectos.Controls.Add(this.pictureBox1);
            this.PanelProyectos.Controls.Add(this.panel6);
            this.PanelProyectos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelProyectos.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelProyectos.Location = new System.Drawing.Point(0, 100);
            this.PanelProyectos.Name = "PanelProyectos";
            this.PanelProyectos.Size = new System.Drawing.Size(200, 50);
            this.PanelProyectos.TabIndex = 3;
            this.PanelProyectos.Click += new System.EventHandler(this.AbrirFormulario_Click);
            this.PanelProyectos.MouseLeave += new System.EventHandler(this.CambiarColorPanel_MouseLeave);
            this.PanelProyectos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CambiarColorPanel_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Proyectos";
            this.label2.Click += new System.EventHandler(this.AbrirFormulario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProMan.Properties.Resources.proyect;
            this.pictureBox1.Location = new System.Drawing.Point(15, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.AbrirFormulario_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(79)))), ((int)(((byte)(133)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 50);
            this.panel6.TabIndex = 0;
            // 
            // PanelInicio
            // 
            this.PanelInicio.Controls.Add(this.label1);
            this.PanelInicio.Controls.Add(this.pictureBox4);
            this.PanelInicio.Controls.Add(this.panel5);
            this.PanelInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelInicio.Location = new System.Drawing.Point(0, 50);
            this.PanelInicio.Name = "PanelInicio";
            this.PanelInicio.Size = new System.Drawing.Size(200, 50);
            this.PanelInicio.TabIndex = 1;
            this.PanelInicio.Tag = "1001";
            this.PanelInicio.Click += new System.EventHandler(this.AbrirFormulario_Click);
            this.PanelInicio.MouseLeave += new System.EventHandler(this.CambiarColorPanel_MouseLeave);
            this.PanelInicio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CambiarColorPanel_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 2;
            this.label1.Tag = "1001";
            this.label1.Text = "Inicio";
            this.label1.Click += new System.EventHandler(this.AbrirFormulario_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProMan.Properties.Resources.home;
            this.pictureBox4.Location = new System.Drawing.Point(15, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "1001";
            this.pictureBox4.Click += new System.EventHandler(this.AbrirFormulario_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 50);
            this.panel5.TabIndex = 0;
            // 
            // TxtNombreApp
            // 
            this.TxtNombreApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtNombreApp.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreApp.ForeColor = System.Drawing.Color.White;
            this.TxtNombreApp.Location = new System.Drawing.Point(0, 0);
            this.TxtNombreApp.Name = "TxtNombreApp";
            this.TxtNombreApp.Size = new System.Drawing.Size(200, 50);
            this.TxtNombreApp.TabIndex = 0;
            this.TxtNombreApp.Text = "Proyect Manager";
            this.TxtNombreApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.BtnMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 32);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnMaximize);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.BtnMinimize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(555, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 32);
            this.panel1.TabIndex = 1;
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMaximize.Image = global::ProMan.Properties.Resources.maximize;
            this.BtnMaximize.Location = new System.Drawing.Point(32, 0);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(32, 32);
            this.BtnMaximize.TabIndex = 1;
            this.BtnMaximize.TabStop = false;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.Image = global::ProMan.Properties.Resources.close;
            this.BtnClose.Location = new System.Drawing.Point(64, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(32, 32);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnMinimize.Image = global::ProMan.Properties.Resources.minimize;
            this.BtnMinimize.Location = new System.Drawing.Point(0, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(32, 32);
            this.BtnMinimize.TabIndex = 3;
            this.BtnMinimize.TabStop = false;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnMenu.Image = global::ProMan.Properties.Resources.menu1;
            this.BtnMenu.Location = new System.Drawing.Point(0, 0);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(32, 32);
            this.BtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnMenu.TabIndex = 0;
            this.BtnMenu.TabStop = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(200, 505);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(651, 50);
            this.panel3.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 555);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelMenu);
            this.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelColaboradores.ResumeLayout(false);
            this.PanelColaboradores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.PanelTareas.ResumeLayout(false);
            this.PanelTareas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PanelProyectos.ResumeLayout(false);
            this.PanelProyectos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelInicio.ResumeLayout(false);
            this.PanelInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox BtnMenu;
        private System.Windows.Forms.Label TxtNombreApp;
        private System.Windows.Forms.PictureBox BtnMinimize;
        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.PictureBox BtnMaximize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelInicio;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelProyectos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel PanelTareas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel PanelColaboradores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel3;
    }
}