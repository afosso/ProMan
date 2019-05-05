using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProMan.Formularios
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            TmrContador.Start();
            TmrContadorProgress.Start();
        }

        private void TmrContador_Tick(object sender, EventArgs e)
        {
            TmrContadorProgress.Stop();
            this.Hide();
            if (File.Exists("C:\\Conexion\\Conexion.xml"))
            {
                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.Show();
            }
            else
            {
                FrmConfiguracionBD configurarBD = new FrmConfiguracionBD();
                configurarBD.Show();
            }
            TmrContador.Stop();
        }

        private void TmrContadorProgress_Tick(object sender, EventArgs e)
        {
            PrgBar.Value++;
        }
    }
}
