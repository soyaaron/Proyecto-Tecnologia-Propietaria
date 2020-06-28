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
    public SqlConnection con { get; set; }

    public string IdUsuario { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Cedula { get; set; }
    public string NCarnet { get; set; }
    public string Tipos { get; set; }
    public string Comentario { get; set; }
    public string Estado { get; set; }

    public string modo { get; set; }
    public partial class FrmAgregarUsuario : Form
    {
        public FrmAgregarUsuario()
        {
            InitializeComponent();
        }

        private void FrmAgregarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                numNumeroReserv.Text = N_Reservacion;
                txtEmpleado.Text = Empleado;
                cbxAulaReserv.Text = Aula;
                txtUsuario.Text = Usuario;
                fexhaReserva.Text = FechaReservacion;
                DTHorasReserva.Text = Cantidad_horas;
                txtComentario.Text = Comentario;
                cbxEstadoAulaReserv.Text = Estado;
                numNumeroReserv.Enabled = modo.Equals("C");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar " + ex.Message);
            }
        }
    }
}
