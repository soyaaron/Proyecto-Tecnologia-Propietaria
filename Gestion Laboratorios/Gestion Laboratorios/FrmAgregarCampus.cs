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
    public partial class FrmAgregarCampus : Form
    {
        public SqlConnection con { get; set; }

        public string IdCampus { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public string modo { get; set; }
        public FrmAgregarCampus()
        {
            InitializeComponent();
        }

        private void FrmAgregarCampus_Load(object sender, EventArgs e)
        {

            try
            {
                numIdCampus.Text = IdCampus;
                txtNombreCampus.Text = Nombre;
                cbxEstado.Text = Estado;
                numIdCampus.Enabled = modo.Equals("C");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar " + ex.Message);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            void verificarCampos()
            {
                VerCampos(txtNombreCampus);


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
                            sql = "insert into Campus Values ('";

                            sql += numIdCampus.Value + "','" + txtNombreCampus.Text + "','" + cbxEstado.Text + "')";
                        }
                        else
                        {
                            sql = " update Campus set ";
                            /*                    sql += "IdCampus = '" + numIdCampus.Value;*/
                            sql += "Nombre = '" + txtNombreCampus.Text + "',";
                            sql += "Estado = '" + cbxEstado.Text + "'";
                            sql += "where IdCampus = '" + numIdCampus.Value + "'";
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete Campus";
                sql += " where IdCampus = '" + numIdCampus.Value + "'";
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
