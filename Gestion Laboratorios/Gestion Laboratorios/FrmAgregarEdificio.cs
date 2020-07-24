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
    public partial class FrmAgregarEdificio : Form
    {
        public SqlConnection con { get; set; }

        public string IdEdificio { get; set; }
        public string Nombre { get; set; }
        public string Campus { get; set; }
        public string Estado { get; set; }
        public string modo { get; set; }

        public FrmAgregarEdificio()
        {
            InitializeComponent();
        }

        private void FrmAgregarEdificio_Load(object sender, EventArgs e)
        {
            //Para llenar combo box desde la base de datos
            string constr = @"Data Source=AARONLAPTOP;Initial Catalog=Gestion_laboratorios;Integrated Security=True";
            z
            using (SqlConnection con = new SqlConnection(constr))
            {
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
                numIdEdificio.Text = IdEdificio;
                txtNombreEdificio.Text = Nombre;
                cbxCampus.Text = Campus;
                cbxEstado.Text = Estado;
                numIdEdificio.Enabled = modo.Equals("C");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar " + ex.Message);
            }
        }

        private void ClickGuardar(object sender, EventArgs e)
        {

            void verificarCampos()
            {
                VerCampos(txtNombreEdificio);


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
                            sql = "insert into Edificios Values ('";

                            sql += numIdEdificio.Value + "','" + txtNombreEdificio.Text + "','" + cbxCampus.Text + "','" + cbxEstado.Text + "')";
                        }
                        else
                        {
                            sql = " update Edificios set ";

                            sql += "Nombre = '" + txtNombreEdificio.Text + "',";
                            sql += "Campus = '" + cbxCampus.Text + "',";
                            sql += "Estado = '" + cbxEstado.Text + "'";
                            sql += "where IdEdificio = '" + numIdEdificio.Value + "'";
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

        private void ClickCancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClickEliminar(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete Edificios";
                sql += " where IdEdificio = '" + numIdEdificio.Value + "'";
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

        //ITEM PARA COMBOBOX 

        private void cbxCampusFiller() {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void CbxCampus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombreEdificio_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumIdEdificio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadCampus(object sender, EventArgs e)
        {
  


        }
    }
}