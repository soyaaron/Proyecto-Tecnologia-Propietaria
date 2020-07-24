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

            //Para llenar combo box desde la base de datos
            string constr = @"Data Source=AARONLAPTOP;Initial Catalog=Gestion_laboratorios;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT IdEdificio, Nombre FROM Edificios", con))
                {

                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    DataRow row = dt.NewRow();
                    row[0] = 0;
                    row[1] = "Seleccione edificio";
                    dt.Rows.InsertAt(row, 0);

                    cbxEdificio.DataSource = dt;
                    cbxEdificio.DisplayMember = "Nombre";
                    cbxEdificio.ValueMember = "IdEdificio";
                }
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT IdCampus, Nombre FROM Campus", con))
                {

                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    DataRow row = dt.NewRow();
                    row[0] = 0;
                    row[1] = "Seleccione campus";
                    dt.Rows.InsertAt(row, 0);

                    cbxCampus.DataSource = dt;
                    cbxCampus.DisplayMember = "Nombre";
                    cbxCampus.ValueMember = "IdCampus";
                }
            }
            //FIN para llenar combo box 

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
            void verificarCampos()
            {
                VerCampos(txtNombreAula);
                VerCampos(txtCapacidad);
                VerCampos(txtCuposRes);


            }

            verificarCampos();
            void VerCampos(TextBox tb)
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    MessageBox.Show(tb.Name + " Debe llenar esta(s) casilla(s)");
                }
                else
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
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
