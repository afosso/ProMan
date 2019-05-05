using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Npgsql;

namespace ProMan.Formularios
{
    public partial class FrmConfiguracionBD : Form
    {
        #region Constructor
        public FrmConfiguracionBD()
        {
            InitializeComponent();
        }
        #endregion

        #region Probar Conexion
        private void BtnProbarConexion_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TxtServidor.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del servidor.", Properties.Resources.TituloAlerta, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(TxtNombreBD.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de la Base de Datos.", Properties.Resources.TituloAlerta, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(TxtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de usuario de la Base de Datos.", Properties.Resources.TituloAlerta, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string puerto = TxtPuerto.Text;
            string servidor = TxtServidor.Text;
            string nombreBD = TxtNombreBD.Text;
            string usuario = TxtUsuario.Text;
            string contrasena = TxtContrasena.Text;

            switch (CmbMotor.Text)
            {
                case "MySQL":
                    try
                    {
                        MySqlConnection conexionMySQL = new MySqlConnection("Server=" + servidor + ";Port=" + puerto + ";Database=" + nombreBD + ";Uid=" + usuario + ";Pwd=" + contrasena);
                        conexionMySQL.Open();
                        if (conexionMySQL.State == ConnectionState.Open)
                        {
                            MessageBox.Show("Conexión realizada con éxito.", Properties.Resources.TituloAlerta, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        conexionMySQL.Close();
                        conexionMySQL = null;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al tratar de realizar la conexión.", Properties.Resources.TituloAlerta, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "SQL Server":
                    try
                    {
                        SqlConnection conexionSQL = new SqlConnection("Data Source=" + servidor + ";Initial Catalog=" + nombreBD + ";User ID=" + usuario + ";Password=" + contrasena);
                        conexionSQL.Open();
                        if(conexionSQL.State == ConnectionState.Open)
                        {
                            MessageBox.Show("Conexión realizada con éxito.", Properties.Resources.TituloAlerta, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        conexionSQL.Close();
                        conexionSQL = null;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al tratar de realizar la conexión.", Properties.Resources.TituloAlerta, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "PostgreSQL":
                    try
                    {
                        NpgsqlConnection conexionPostGreSQL = new NpgsqlConnection("Server=" + servidor + "; Database=" + nombreBD + "; User Id=" + usuario + "; Password= " + contrasena + "; Persist Security Info=true");
                        conexionPostGreSQL.Open();
                        if (conexionPostGreSQL.State == ConnectionState.Open)
                        {
                            MessageBox.Show("Conexión realizada con éxito.", Properties.Resources.TituloAlerta, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        conexionPostGreSQL.Close();
                        conexionPostGreSQL = null;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al tratar de realizar la conexión.", Properties.Resources.TituloAlerta, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default:
                    MessageBox.Show("Debe seleccionar un motor de Base de Datos.", Properties.Resources.TituloAlerta, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        #endregion

        #region Cargar Formulario
        private void FrmConfiguracionBD_Load(object sender, EventArgs e)
        {
            CmbMotor.SelectedIndex = 0;
        }
        #endregion

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
