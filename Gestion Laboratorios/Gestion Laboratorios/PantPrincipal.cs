using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Gestion_Laboratorios
{
    public partial class PantPrincipal : Form
    {

        public Reservacion reserva { get; set; }
        private ReservEntities entities = new ReservEntities();

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
            dvgReservaciones.DataSource = entities.Reservacion.ToList();
        }


        private void btnDirigeAgregarRes(object sender, EventArgs e)
        {
            FrmReservacion frmres = new FrmReservacion();
            frmres.ShowDialog();
        }

        private void BtnBuscarReservas_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }
       private void consultarPorCriterio()
        {
            var reservacion = from em in entities.Reservacion
                              where (em.N_Reservacion.ToString().StartsWith(txtBuscar.Text) ||
                              em.Usuario.StartsWith(txtBuscar.Text) 
                              )
                              select em;
            dvgReservaciones.DataSource = reservacion.ToList();
        }

        private void PantPrincipal_Activado(object sender, EventArgs e)
        {
            consultarReservas();
        }


        private void dgvReserv_CellDobleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dvgReservaciones.SelectedRows[0];
            Reservacion reserva = new Reservacion();
            reserva.N_Reservacion = Int32.Parse(row.Cells[0].Value.ToString());
            reserva.Empleado = row.Cells[1].Value.ToString();
            reserva.Aula = row.Cells[2].Value.ToString();
            reserva.Usuario = row.Cells[3].Value.ToString();
            reserva.FechaReservacion = Convert.ToDateTime(row.Cells[4]);
             reserva.Cantidad_horas = row.Cells[5].Value.ToString();
            reserva.Comentario = row.Cells[6].Value.ToString();


            FrmReservacion frmres = new FrmReservacion();
            frmres.reserva = reserva;
            frmres.ShowDialog();
        }

        private void ClickGestionCampus(object sender, EventArgs e)
        {
            Gestion_de_Campus f3 = new Gestion_de_Campus();
            f3.Show();
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
    }
}
