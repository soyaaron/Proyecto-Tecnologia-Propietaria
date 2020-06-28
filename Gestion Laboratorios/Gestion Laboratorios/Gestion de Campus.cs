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
    public partial class Gestion_de_Campus : Form
    {
        public SqlConnection con = null;
        public Gestion_de_Campus()
        {
            InitializeComponent();
        }

        private void Gestion_de_Campus_Load(object sender, EventArgs e)
        {
            consultarCampus();
        }

        private void btnBuscarCampus(object sender, EventArgs e)
        {
            consultarCampus();
        }

        private void consultarCampus() {
            try
            {
                con = new SqlConnection("Data Source=AARONLAPTOP;Initial Catalog=Gestion_laboratorios;Integrated Security=True");
                con.Open();
                string sql = "select * from Campus";
                if (txtBusqCampus.Text.Length > 0) {

                    sql += " where " + txtBusqCampus.Text + " like '%' ";
                    sql += " order by " + txtBusqCampus.Text;
                }
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCampus.DataSource = dt;
                dgvCampus.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ejecutar consulta: " + ex.Message);
                txtBusqCampus.Clear();
            }
        }

        private void BtnAgregarCampus_Click(object sender, EventArgs e)
        {
            FrmAgregarCampus frmcmp = new FrmAgregarCampus();
            frmcmp.con = con;
            frmcmp.modo = "C";
            frmcmp.ShowDialog();
        }

        private void GestionCampusAct(object sender, EventArgs e)
        {
            consultarCampus();
        }

        private void dvgCampusDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvCampus.SelectedRows[0];
                FrmAgregarCampus frm = new FrmAgregarCampus();
                frm.IdCampus = row.Cells[0].Value.ToString();
                frm.Nombre = row.Cells[1].Value.ToString();
                frm.Estado = row.Cells[2].Value.ToString();
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
