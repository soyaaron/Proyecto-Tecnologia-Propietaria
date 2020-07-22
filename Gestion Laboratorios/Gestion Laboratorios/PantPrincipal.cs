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
    public partial class PantPrincipal : Form
    {
        public SqlConnection con = null;
        //
        public PantPrincipal()
        {
            InitializeComponent();
        }

        private void PantPrincipal_Load(object sender, EventArgs e)
        {
            consultarReservas();
        }

        private void consultarReservas()
        {
            try
            {
                con = new SqlConnection("Data Source=AARONLAPTOP;Initial Catalog=Gestion_laboratorios;Integrated Security=True");
                con.Open();
                string sql = "select * from Reservacion";
                if (txtBuscar.Text.Length > 0)
                {
                    sql += " where " + txtBuscar.Text + " like '%' ";
                    sql += " order by " + txtBuscar.Text;
                }
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReservaciones.DataSource = dt;
                dgvReservaciones.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar consulta: " + ex.Message);
                txtBuscar.Clear();
            }
        }

        private void BtnBuscarReservas_Click(object sender, EventArgs e)
        {

            consultarReservas();
        }
        private void btnDirigeAgregarRes(object sender, EventArgs e)
        {
            FrmReservacion frmres = new FrmReservacion();
            frmres.con = con;
            frmres.modo = "C";
            frmres.ShowDialog();
        }


        private void PantPrincipal_Activado(object sender, EventArgs e)
        {
            consultarReservas();
        }


        private void dgvReserv_CellDobleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow row = this.dgvReservaciones.SelectedRows[0];
                FrmReservacion frm = new FrmReservacion();
                frm.N_Reservacion = row.Cells[0].Value.ToString();
                frm.Empleado = row.Cells[1].Value.ToString();
                frm.Aula = row.Cells[2].Value.ToString();
                frm.Usuario = row.Cells[3].Value.ToString();
                frm.FechaReservacion = row.Cells[4].Value.ToString();
                frm.Cantidad_horas = row.Cells[5].Value.ToString();
                frm.Comentario = row.Cells[6].Value.ToString();
                frm.Estado = row.Cells[7].Value.ToString();
                frm.modo = "U";
                frm.con = con;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al editar" + ex.Message);
            }

        }


        //DIRIGIR A LAS DIFERENTES PANTALLAS 
        private void ClickGestionCampus(object sender, EventArgs e)
        {
            Gestion_de_Campus f3 = new Gestion_de_Campus();
            f3.ShowDialog();
        }


        private void DirigirGestionUsuario(object sender, EventArgs e)
        {
            Gestions_Usuarios gestuser = new Gestions_Usuarios();
            gestuser.ShowDialog();
        }

        private void DirigirGestionEmp(object sender, EventArgs e)
        {
            FrmGestionEmp gestemp = new FrmGestionEmp();
            gestemp.ShowDialog();
        }

        private void DirigirGestionAulas(object sender, EventArgs e)
        {
            FrmGestionAulas getau = new FrmGestionAulas();
            getau.ShowDialog();
        }

        private void DirGestEmp(object sender, EventArgs e)
        {
            GestionEdificiosForm edfrm = new GestionEdificiosForm();
            edfrm.ShowDialog();

        }
    }
}
