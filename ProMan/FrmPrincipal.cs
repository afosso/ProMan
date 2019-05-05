using ProMan.Entidades;
using ProMan.Formularios;
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
        #region Objetos
        private class FormularioMdi
        {
            public string nombre { get; set; }
            public string tag { get; set; }
            public Panel btnReferencia { get; set; }
        }

        List<FormularioMdi> listadoFormularios;
        #endregion

        #region Constructor
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos

        #region Click
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Size.Width == 200)
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
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
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
        #endregion

        #region Load
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //activarFormulario(1001);
        }
        #endregion

        #region Mouse
        private void CambiarColorPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ((Panel)sender).BackColor = Color.FromArgb(64, 96, 128);
        }
        private void CambiarColorPanel_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.FromArgb(26, 79, 133);
        }
        #endregion

        #endregion

        #region Métodos privados
        private void activarFormulario(int tag)
        {
            this.Cursor = Cursors.WaitCursor;
            Form formularioActivo = MdiChildren.FirstOrDefault(fo => Convert.ToInt32(fo.Tag) == tag);
            if (formularioActivo == null)
            {
                Form formularioVisualizar = null;


                if (tag == 1001)
                {
                    formularioVisualizar = new FrmHome();
                }

                if (formularioVisualizar != null)
                {
                    formularioVisualizar.MdiParent = this;
                    formularioVisualizar.Dock = DockStyle.Fill;
                    formularioVisualizar.Show();
                }
            }
            else
            {
                formularioActivo.Activate();
            }
            this.Cursor = Cursors.Default;
        }
        private void cargarListadoFormularioMdi()
        {
            listadoFormularios = new List<FormularioMdi>();
            listadoFormularios.Add(new FormularioMdi() { tag = "1001", nombre = "Home", btnReferencia = PanelInicio });
        }
        #endregion

        private void AbrirFormulario_Click(object sender, EventArgs e)
        {
            activarFormulario(Convert.ToInt32(((Control)sender).Tag));
        }
        
    }
}
