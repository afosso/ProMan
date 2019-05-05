namespace ProMan.Formularios
{
    partial class FrmConfiguracionBD
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
            this.PanelHead = new System.Windows.Forms.Panel();
            this.lollipopLabel1 = new LollipopLabel();
            this.PanelFooter = new System.Windows.Forms.Panel();
            this.BtnContinuar = new LollipopFlatButton();
            this.PanelBody = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbMotor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombreBD = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnProbarConexion = new LollipopButton();
            this.TxtPuerto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtServidor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PanelHead.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            this.PanelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHead
            // 
            this.PanelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(79)))), ((int)(((byte)(133)))));
            this.PanelHead.Controls.Add(this.lollipopLabel1);
            this.PanelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHead.Location = new System.Drawing.Point(0, 0);
            this.PanelHead.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(560, 50);
            this.PanelHead.TabIndex = 0;
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel1.ForeColor = System.Drawing.Color.White;
            this.lollipopLabel1.Location = new System.Drawing.Point(135, 16);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(291, 18);
            this.lollipopLabel1.TabIndex = 0;
            this.lollipopLabel1.Text = "Configurar conexión con la base de datos";
            // 
            // PanelFooter
            // 
            this.PanelFooter.Controls.Add(this.BtnContinuar);
            this.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelFooter.Location = new System.Drawing.Point(0, 416);
            this.PanelFooter.Name = "PanelFooter";
            this.PanelFooter.Size = new System.Drawing.Size(560, 50);
            this.PanelFooter.TabIndex = 2;
            // 
            // BtnContinuar
            // 
            this.BtnContinuar.BackColor = System.Drawing.Color.Transparent;
            this.BtnContinuar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnContinuar.FontColor = "#508ef5";
            this.BtnContinuar.Location = new System.Drawing.Point(417, 0);
            this.BtnContinuar.Name = "BtnContinuar";
            this.BtnContinuar.Size = new System.Drawing.Size(143, 50);
            this.BtnContinuar.TabIndex = 0;
            this.BtnContinuar.Text = "Continuar";
            this.BtnContinuar.Click += new System.EventHandler(this.BtnContinuar_Click);
            // 
            // PanelBody
            // 
            this.PanelBody.Controls.Add(this.TxtServidor);
            this.PanelBody.Controls.Add(this.label6);
            this.PanelBody.Controls.Add(this.TxtPuerto);
            this.PanelBody.Controls.Add(this.label5);
            this.PanelBody.Controls.Add(this.BtnProbarConexion);
            this.PanelBody.Controls.Add(this.TxtContrasena);
            this.PanelBody.Controls.Add(this.label4);
            this.PanelBody.Controls.Add(this.TxtUsuario);
            this.PanelBody.Controls.Add(this.label3);
            this.PanelBody.Controls.Add(this.TxtNombreBD);
            this.PanelBody.Controls.Add(this.label2);
            this.PanelBody.Controls.Add(this.CmbMotor);
            this.PanelBody.Controls.Add(this.label1);
            this.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBody.Location = new System.Drawing.Point(0, 50);
            this.PanelBody.Name = "PanelBody";
            this.PanelBody.Size = new System.Drawing.Size(560, 366);
            this.PanelBody.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Motor de base de datos";
            // 
            // CmbMotor
            // 
            this.CmbMotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMotor.FormattingEnabled = true;
            this.CmbMotor.Items.AddRange(new object[] {
            "MySQL",
            "SQL Server",
            "PostgreSQL"});
            this.CmbMotor.Location = new System.Drawing.Point(51, 43);
            this.CmbMotor.Name = "CmbMotor";
            this.CmbMotor.Size = new System.Drawing.Size(442, 29);
            this.CmbMotor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre de la base de datos";
            // 
            // TxtNombreBD
            // 
            this.TxtNombreBD.Location = new System.Drawing.Point(51, 161);
            this.TxtNombreBD.Name = "TxtNombreBD";
            this.TxtNombreBD.Size = new System.Drawing.Size(442, 29);
            this.TxtNombreBD.TabIndex = 5;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(51, 218);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(216, 29);
            this.TxtUsuario.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuario";
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Location = new System.Drawing.Point(51, 275);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.Size = new System.Drawing.Size(442, 29);
            this.TxtContrasena.TabIndex = 11;
            this.TxtContrasena.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contraseña";
            // 
            // BtnProbarConexion
            // 
            this.BtnProbarConexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(79)))), ((int)(((byte)(133)))));
            this.BtnProbarConexion.BGColor = "26; 79; 133";
            this.BtnProbarConexion.FontColor = "#ffffff";
            this.BtnProbarConexion.Location = new System.Drawing.Point(350, 310);
            this.BtnProbarConexion.Name = "BtnProbarConexion";
            this.BtnProbarConexion.Size = new System.Drawing.Size(143, 41);
            this.BtnProbarConexion.TabIndex = 12;
            this.BtnProbarConexion.Text = "Probar Conexión";
            this.BtnProbarConexion.Click += new System.EventHandler(this.BtnProbarConexion_Click);
            // 
            // TxtPuerto
            // 
            this.TxtPuerto.Location = new System.Drawing.Point(277, 218);
            this.TxtPuerto.Name = "TxtPuerto";
            this.TxtPuerto.Size = new System.Drawing.Size(216, 29);
            this.TxtPuerto.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Puerto";
            // 
            // TxtServidor
            // 
            this.TxtServidor.Location = new System.Drawing.Point(51, 100);
            this.TxtServidor.Name = "TxtServidor";
            this.TxtServidor.Size = new System.Drawing.Size(442, 29);
            this.TxtServidor.TabIndex = 3;
            this.TxtServidor.Text = "localhost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Servidor";
            // 
            // FrmConfiguracionBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 466);
            this.Controls.Add(this.PanelBody);
            this.Controls.Add(this.PanelFooter);
            this.Controls.Add(this.PanelHead);
            this.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmConfiguracionBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConfiguracionBD";
            this.Load += new System.EventHandler(this.FrmConfiguracionBD_Load);
            this.PanelHead.ResumeLayout(false);
            this.PanelHead.PerformLayout();
            this.PanelFooter.ResumeLayout(false);
            this.PanelBody.ResumeLayout(false);
            this.PanelBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHead;
        private LollipopLabel lollipopLabel1;
        private System.Windows.Forms.Panel PanelFooter;
        private LollipopFlatButton BtnContinuar;
        private System.Windows.Forms.Panel PanelBody;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbMotor;
        private System.Windows.Forms.Label label1;
        private LollipopButton BtnProbarConexion;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombreBD;
        private System.Windows.Forms.TextBox TxtPuerto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtServidor;
        private System.Windows.Forms.Label label6;
    }
}