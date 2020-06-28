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
    public partial class GestionEdificiosForm : Form
    {
        public SqlConnection con = null;
        public GestionEdificiosForm()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void GestionEdificiosForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestion_laboratoriosDataSet.Edificios' table. You can move, or remove it, as needed.

            consultarEdificio();
        }
        private void ActGestED(object sender, EventArgs e)
        {
            consultarEdificio();
        }
        private void consultarEdificio()
        {
            try
            {
                con = new SqlConnection("Data Source=AARONLAPTOP;Initial Catalog=Gestion_laboratorios;Integrated Security=True");
                con.Open();
                string sql = "select * from Edificios";
                if (txtBusqEd.Text.Length > 0)
                {

                    sql += " where " + txtBusqEd.Text + " like '%' ";
                    sql += " order by " + txtBusqEd.Text;
                }
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEdificios.DataSource = dt;
                dgvEdificios.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ejecutar consulta: " + ex.Message);
                txtBusqEd.Clear();
            }
        }

        private void btnAgregarEdificoClick(object sender, EventArgs e)
        {
            FrmAgregarEdificio frmed = new FrmAgregarEdificio();
            frmed.con = con;
            frmed.modo = "C";
            frmed.ShowDialog();
        }

        private void EdEdificio(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvEdificios.SelectedRows[0];
                FrmAgregarEdificio frm = new FrmAgregarEdificio();
                frm.IdEdificio = row.Cells[0].Value.ToString();
                frm.Nombre = row.Cells[1].Value.ToString();
                frm.Campus = row.Cells[2].Value.ToString();
                frm.Estado = row.Cells[3].Value.ToString();
                frm.modo = "U";
                frm.con = con;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ejecutar consulta: " + ex.Message);
            }
        }
    }
}
