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
    public partial class AgregarAula : Form
    {
        public SqlConnection con { get; set; }

        public string IdAula { get; set; }
        public string Nombre { get; set; }
        public string TipoAula { get; set; }
        public string Edificio { get; set; }
        public string Capacidad { get; set; }
        public string CuposReservados { get; set; }

        public string Estado { get; set; }
        public string modo { get; set; }
        public AgregarAula()
        {
            InitializeComponent();
        }

        private void AgregarAula_Load(object sender, EventArgs e)
        {
            try
            {
                numIdAula.Text = IdAula;
                txtNombreAula.Text = Nombre;
                txtTipoAula.Text = TipoAula;
                cbxEdificio.Text = Edificio;
                txtCapacidad.Text = Capacidad;
                txtCuposRes.Text = CuposReservados;
                cbxEstado.Text = Estado;
                numIdAula.Enabled = modo.Equals("C");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar " + ex.Message);
            }
        }

 
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete Aula";
                sql += " where IdAula = '" + numIdAula.Value + "'";
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                if (modo.Equals("C"))
                {
                    sql = "insert into Aula Values ('";

                    sql += numIdAula.Value + "','" + txtNombreAula.Text + "','" + txtTipoAula.Text + "','" + cbxEdificio.Text + "','" + txtCapacidad.Text + "','" + txtCuposRes.Text + "','" + cbxEstado.Text + "')";
                }
                else
                {
                    sql = " update Aula set ";

                    sql += "Nombre = '" + txtNombreAula.Text + "',";
                    sql += "TipoAula = '" + txtTipoAula.Text + "',";
                    sql += "Edificio = '" + cbxEdificio.Text + "',";
                    sql += "Capacidad = '" + txtCapacidad.Text + "',";
                    sql += "CuposReservados = '" + txtCuposRes.Text + "',";
                    sql += "Estado = '" + cbxEstado.Text + "'";
                    sql += "where IdAula = '" + numIdAula.Value + "'";
                }
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro guardado con exito");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar " + ex.Message);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
