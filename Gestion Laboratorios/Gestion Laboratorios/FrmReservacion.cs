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
    public partial class FrmReservacion : Form
    {
        public Reservacion reserva { get; set; }
        private ReservEntities entities = new ReservEntities();

        public FrmReservacion()
        {
            InitializeComponent();
        }

        private void FrmReservar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestion_laboratoriosDataSet.Aula' table. You can move, or remove it, as needed.
            this.aulaTableAdapter.Fill(this.gestion_laboratoriosDataSet.Aula);
            if (reserva != null)
            {
                txtUsuario.Text = reserva.Usuario.ToString();
                txtEmpleado.Text = reserva.Empleado.ToString();
                fexhaReserva.Text = reserva.FechaReservacion.ToString();
                // NO Encuentro como parsear la hora para que la bd entienda, la bd acepta un dato time 
                
                DTHorasReserva.Text = reserva.Cantidad_horas.ToString();
                cbxAulaReserv.Text = reserva.Aula.ToString(); 


            }
        }

        private void BtnGuardarReserva_Click(object sender, EventArgs e)
        {



            entities.Reservacion.Add(
                new Reservacion
                {
                    Empleado = txtEmpleado.Text,
                    Usuario = txtUsuario.Text,
                    Aula = cbxAulaReserv.Text,
                    FechaReservacion = fexhaReserva.Value,
                Cantidad_horas = DTHorasReserva.Text,
                   Estado = cbxEstadoAulaReserv.Text,
                    Comentario = txtComentario.Text
                }); ; 
            entities.SaveChanges();
            MessageBox.Show("Reserva guarada con exito");
            this.Close();

        }

        private void CbxAulaReserv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
