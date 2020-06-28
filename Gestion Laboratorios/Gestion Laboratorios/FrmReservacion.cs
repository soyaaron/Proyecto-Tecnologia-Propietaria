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
    public partial class FrmReservacion : Form
    {
        public SqlConnection con { get; set; }

        public string N_Reservacion { get; set; }
        public string Empleado { get; set; }
        public string Aula { get; set; }
        public string Usuario { get; set; }
        public string FechaReservacion { get; set; }
        public string Cantidad_horas { get; set; }
        public string Comentario { get; set; }
        public string Estado { get; set; }

        public string modo { get; set; }



        public FrmReservacion()
        {
            InitializeComponent();
        }

        private void FrmReservar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestion_laboratoriosDataSet.Aula' table. You can move, or remove it, as needed.

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

        private void BtnGuardarReserva_Click(object sender, EventArgs e)
        {

            try
            {
                string sql = "";
                if (modo.Equals("C"))
                {
                    sql = "insert into Reservacion Values ('";
                    sql += numNumeroReserv.Value + "','" + txtEmpleado.Text + "','" + cbxAulaReserv.Text + "','" + txtUsuario.Text + "','";
                    sql += fexhaReserva.Text + "','" + DTHorasReserva.Text + "','" + txtComentario.Text + "','" + cbxEstadoAulaReserv.Text + "')";
                }
                else
                {
                    sql = " update Reservacion set ";

                    sql += "Empleado = '" + txtEmpleado.Text + "',";
                    sql += "Aula = '" + cbxAulaReserv.Text + "',";
                    sql += "Usuario = '" + txtUsuario.Text + "',";
                    sql += "FechaReservacion = '" + fexhaReserva.Value + "',";
                    sql += "Cantidad_horas = '" + DTHorasReserva.Text + "',";
                    sql += "Estado = '" + cbxEstadoAulaReserv.Text + "',";
                    sql += "Comentario = '" + txtComentario.Text + "'";                   
                    sql += "where N_Reservacion = '" + numNumeroReserv.Value + "'";

                }
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Guardado con exito");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar " + ex.Message);
            }



        }

        private void CbxAulaReserv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EliminarReserv_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete Reservacion";
                sql += " where N_Reservacion = '" +numNumeroReserv.Value+"'";
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

        private void BtnCancelarReserva_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

