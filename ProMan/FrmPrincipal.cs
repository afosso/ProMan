using ProMan.Formularios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
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
        private void AbrirFormulario_Click(object sender, EventArgs e)
        {
            DesactivarSeleccion = Color.Transparent;
            activarFormulario(Convert.ToInt32(((Control)sender).Tag));
        }
        #endregion

        #region Load
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            activarFormulario(1001);
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

        #region Mover Formulario
        private void PanelHead_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void PanelHead_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void PanelHead_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        #endregion

        #region DoubleClick
        private void PanelHead_DoubleClick(object sender, EventArgs e)
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
                    PanelSelInicio.BackColor = Color.FromArgb(128, 191, 255);
                }

                if (tag == 1002)
                {
                    PanelSelProyectos.BackColor = Color.FromArgb(128, 191, 255);
                }

                if (tag == 1003)
                {
                    PanelSelTareas.BackColor = Color.FromArgb(128, 191, 255);
                }

                if (tag == 1004)
                {
                    PanelSelColaboradores.BackColor = Color.FromArgb(128, 191, 255);
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
                if(tag == 1001)
                {
                    PanelSelInicio.BackColor = Color.FromArgb(128, 191, 255);
                }

                if (tag == 1002)
                {
                    PanelSelProyectos.BackColor = Color.FromArgb(128, 191, 255);
                }

                if (tag == 1003)
                {
                    PanelSelTareas.BackColor = Color.FromArgb(128, 191, 255);
                }

                if(tag == 1004)
                {
                    PanelSelColaboradores.BackColor = Color.FromArgb(128, 191, 255);
                }

                formularioActivo.Activate();
            }
            this.Cursor = Cursors.Default;
        }
        private void cargarListadoFormularioMdi()
        {
            listadoFormularios = new List<FormularioMdi>();
            listadoFormularios.Add(new FormularioMdi() { tag = "1001", nombre = "Home", btnReferencia = PanelInicio });
        }
        private Color DesactivarSeleccion
        {
            set
            {
                PanelSelColaboradores.BackColor = value;
                PanelSelInicio.BackColor = value;
                PanelSelProyectos.BackColor = value;
                PanelSelTareas.BackColor = value;
            }
        }
        #endregion
    }
}
