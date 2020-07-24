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
            //Para llenar combo box desde la base de datos
            string constr = @"Data Source=AARONLAPTOP;Initial Catalog=Gestion_laboratorios;Integrated Security=True";
           
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT IdAula, Nombre FROM Aula", con))
                {
                    //Fill the DataTable with records from Table.
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    //Insert the Default Item to DataTable.
                    DataRow row = dt.NewRow();
                    row[0] = 0;
                    row[1] = "Seleccione aula";
                    dt.Rows.InsertAt(row, 0);

                    //Assign DataTable as DataSource.
                    cbxAulaReserv.DataSource = dt;
                    cbxAulaReserv.DisplayMember = "Nombre";
                    cbxAulaReserv.ValueMember = "IdAula";
                }
            }
            //FIN para llenar combo box 


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
        //Validacion



        //Guardar reserva

        private void BtnGuardarReserva_Click(object sender, EventArgs e)
        {
            void verificarCampos()
            {
                VerCampos(txtUsuario);


            }

            verificarCampos();
            void VerCampos(TextBox tb)
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    MessageBox.Show(tb.Name + " Debe llenar esta(s) casilla(s)");
                }
                else
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

