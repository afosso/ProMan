namespace ProMan.Formularios
{
    partial class FrmHome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lollipopSmallCard2 = new LollipopSmallCard();
            this.lollipopSmallCard1 = new LollipopSmallCard();
            this.lollipopSmallCard3 = new LollipopSmallCard();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lollipopSmallCard3);
            this.panel1.Controls.Add(this.lollipopSmallCard2);
            this.panel1.Controls.Add(this.lollipopSmallCard1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 150);
            this.panel1.TabIndex = 0;
            // 
            // lollipopSmallCard2
            // 
            this.lollipopSmallCard2.FontColor = "#5cb85c";
            this.lollipopSmallCard2.Image = global::ProMan.Properties.Resources.task48;
            this.lollipopSmallCard2.Info = "100";
            this.lollipopSmallCard2.Location = new System.Drawing.Point(231, 25);
            this.lollipopSmallCard2.Name = "lollipopSmallCard2";
            this.lollipopSmallCard2.Size = new System.Drawing.Size(182, 52);
            this.lollipopSmallCard2.TabIndex = 1;
            this.lollipopSmallCard2.Text = "Cantidad de Tareas";
            this.lollipopSmallCard2.ThumbnailColor = "#5cb85c";
            // 
            // lollipopSmallCard1
            // 
            this.lollipopSmallCard1.FontColor = "#1A4F85";
            this.lollipopSmallCard1.Image = global::ProMan.Properties.Resources.proyect64;
            this.lollipopSmallCard1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.lollipopSmallCard1.Info = "50";
            this.lollipopSmallCard1.Location = new System.Drawing.Point(12, 25);
            this.lollipopSmallCard1.Name = "lollipopSmallCard1";
            this.lollipopSmallCard1.Size = new System.Drawing.Size(198, 52);
            this.lollipopSmallCard1.TabIndex = 0;
            this.lollipopSmallCard1.Text = "Cantidad de proyectos";
            this.lollipopSmallCard1.ThumbnailColor = "#1A4F85";
            // 
            // lollipopSmallCard3
            // 
            this.lollipopSmallCard3.FontColor = "#5cb85c";
            this.lollipopSmallCard3.Image = global::ProMan.Properties.Resources.task48;
            this.lollipopSmallCard3.Info = "100";
            this.lollipopSmallCard3.Location = new System.Drawing.Point(12, 83);
            this.lollipopSmallCard3.Name = "lollipopSmallCard3";
            this.lollipopSmallCard3.Size = new System.Drawing.Size(198, 52);
            this.lollipopSmallCard3.TabIndex = 2;
            this.lollipopSmallCard3.Text = "Cantidad de Tareas";
            this.lollipopSmallCard3.ThumbnailColor = "#5cb85c";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHome";
            this.Tag = "1001";
            this.Text = "FrmHome";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private LollipopSmallCard lollipopSmallCard1;
        private LollipopSmallCard lollipopSmallCard2;
        private LollipopSmallCard lollipopSmallCard3;
    }
}