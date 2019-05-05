using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProMan
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if(PanelMenu.Size.Width == 200)
            {
                PanelMenu.Width = 50;
                TxtNombreApp.Text = "PM";
            }
            else
            {
                PanelMenu.Width = 200;
                TxtNombreApp.Text = "Proyect Manager";
            }
        }

        private void CambiarColorPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ((Panel)sender).BackColor = Color.FromArgb(64, 96, 128);
        }

        private void CambiarColorPanel_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.FromArgb(26, 79, 133);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
