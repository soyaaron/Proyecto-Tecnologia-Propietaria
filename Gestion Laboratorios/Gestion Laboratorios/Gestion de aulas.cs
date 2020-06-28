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
    public partial class FrmGestionAulas : Form
    {
        public SqlConnection con = null;


        public FrmGestionAulas()
        {
            InitializeComponent();
        }

        private void FrmGestionAulas_Load(object sender, EventArgs e)
        {

            consultarAulas();

        }
        private void consultarAulas()
        {
            try
            {
                con = new SqlConnection("Data Source=AARONLAPTOP;Initial Catalog=Gestion_laboratorios;Integrated Security=True");
                con.Open();
                string sql = "select * from Aula";
                if (txtBusqAula.Text.Length > 0)
                {

                    sql += " where " + txtBusqAula.Text + " like '%' ";
                    sql += " order by " + txtBusqAula.Text;
                }
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAulas.DataSource = dt;
                dgvAulas.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ejecutar consulta: " + ex.Message);
                txtBusqAula.Clear();
            }
        }

        private void DirigirAgregarAula(object sender, EventArgs e)
        {
            AgregarAula getaddau = new AgregarAula ();
            getaddau.con = con;
            getaddau.modo = "C";
            getaddau.ShowDialog();
        }

        private void dgvdoubleclick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvAulas.SelectedRows[0];
                AgregarAula frm = new AgregarAula();
                frm.IdAula = row.Cells[0].Value.ToString();
                frm.Nombre = row.Cells[1].Value.ToString();
                frm.TipoAula = row.Cells[2].Value.ToString();
                frm.Edificio = row.Cells[3].Value.ToString();
                frm.Capacidad = row.Cells[4].Value.ToString();
                frm.CuposReservados = row.Cells[5].Value.ToString();
                frm.Estado = row.Cells[6].Value.ToString();
                frm.modo = "U";
                frm.con = con;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ejecutar consulta: " + ex.Message);
            }
        }

        private void GestAulaAct(object sender, EventArgs e)
        {
            consultarAulas();
        }
    }
}
