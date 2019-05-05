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
    }
}
