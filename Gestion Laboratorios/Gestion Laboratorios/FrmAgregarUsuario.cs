using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Laboratorios
{

    public partial class FrmAgregarUsuario : Form
    {
        public SqlConnection con { get; set; }

        public string IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string NCarnet { get; set; }
        public string TipoUsuario { get; set; }

        public string Estado { get; set; }

        public string modo { get; set; }
        public FrmAgregarUsuario()
        {
            InitializeComponent();
        }

        private void FrmAgregarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                numIdUsr.Text = IdUsuario;
                txtNombreUsr.Text = Nombre;
                txtApellidoUsr.Text = Apellido;
                txtCedula.Text = Cedula;
                txtNoCarnet.Text = NCarnet;
                cbxTipo.Text = TipoUsuario;
                cbxEstado.Text = Estado;
         
                numIdUsr.Enabled = modo.Equals("C");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar " + ex.Message);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                if (modo.Equals("C"))
                {
                    sql = "insert into Usuario Values ('";
                    sql += numIdUsr.Value + "','" + txtNombreUsr.Text + "','" + txtApellidoUsr.Text + "','" + txtCedula.Text + "','";
                    sql += txtNoCarnet.Text + "','" + cbxTipo.Text + "','" + cbxEstado.Text + "')";
                }
                else
                {
                    sql = " update Usuario set ";

                    sql += "Nombre = '" + txtNombreUsr.Text + "',";
                    sql += "Apellido = '" + txtApellidoUsr.Text + "',";
                    sql += "Cedula = '" + txtCedula.Text + "',";
                    sql += "NCarnet = '" + txtNoCarnet.Text + "',";
                    sql += "TipoUsuario = '" + cbxTipo.Text + "',";
                    sql += "Estado = '" + cbxEstado.Text + "',";


                }
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Guardado con exito");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar " + ex.Message);
            }
        }

        private void FrmUsrAct(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete Usuario";
                sql += " where IdUsuario = '" + numIdUsr.Value + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro eliminiado");
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al eliminar " + ex.Message);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }
