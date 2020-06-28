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
    public partial class Gestions_Usuarios : Form
    {
        public SqlConnection con = null;
        public Gestions_Usuarios()
        {
            InitializeComponent();
        }
        private void Gestions_Usuarios_Load(object sender, EventArgs e)
        {
            consultaUsuarios();
        }

       private void consultaUsuarios(){
            try
            {
                con = new SqlConnection("Data Source=AARONLAPTOP;Initial Catalog=Gestion_laboratorios;Integrated Security=True");
                con.Open();
                string sql = "select * from Usuario";
                if (txtBuscar.Text.Length > 0)
                {
                    sql += " where " + txtBuscar.Text + " like '%' ";
                    sql += " order by " + txtBuscar.Text;
                }
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUser.DataSource = dt;
                dgvUser.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar consulta: " + ex.Message);
                txtBuscar.Clear();
            }
        }

        private void d(object sender, EventArgs e)
        {

        }

        private void DirgestUsr_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario frmres = new FrmAgregarUsuario();
            frmres.con = con;
            frmres.modo = "C";
            frmres.ShowDialog();
        }
    }
}
