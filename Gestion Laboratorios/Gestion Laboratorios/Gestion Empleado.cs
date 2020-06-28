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
    public partial class FrmGestionEmp : Form
    {
        public SqlConnection con = null;
        public FrmGestionEmp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

                FrmAgregarEmpleado frmres = new FrmAgregarEmpleado();
                frmres.con = con;
                frmres.modo = "C";
                frmres.ShowDialog();
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            consultarEmp();
        }

        private void consultarEmp()
        {
            try
            {
                con = new SqlConnection("Data Source=AARONLAPTOP;Initial Catalog=Gestion_laboratorios;Integrated Security=True");
                con.Open();
                string sql = "select * from Empleado";
                if (txtBuscar.Text.Length > 0)
                {
                    sql += " where " + txtBuscar.Text + " like '%' ";
                    sql += " order by " + txtBuscar.Text;
                }
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEmp.DataSource = dt;
                dgvEmp.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar consulta: " + ex.Message);
                txtBuscar.Clear();
            }
        }


        private void dgvEmpDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvEmp.SelectedRows[0];
                FrmAgregarEmpleado frm = new FrmAgregarEmpleado();
                frm.Id_Empleado = row.Cells[0].Value.ToString();
                frm.Nombre = row.Cells[1].Value.ToString();
                frm.Apellido = row.Cells[2].Value.ToString();
                frm.Cedula = row.Cells[3].Value.ToString();
                frm.Tanda = row.Cells[4].Value.ToString();
                frm.FechaIngreso = row.Cells[5].Value.ToString();
                frm.Estado = row.Cells[6].Value.ToString();
                frm.modo = "U";
                frm.con = con;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al editar" + ex.Message);
            }

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GestEmpAct(object sender, EventArgs e)
        {
            consultarEmp();
        }
    }
}
