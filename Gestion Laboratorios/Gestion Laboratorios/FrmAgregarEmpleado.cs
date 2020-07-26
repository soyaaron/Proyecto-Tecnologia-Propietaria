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
    public partial class FrmAgregarEmpleado : Form
    {
        public SqlConnection con { get; set; }

        public string Id_Empleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Tanda { get; set; }
        public string FechaIngreso { get; set; }
        public string Estado { get; set; }

        public string modo { get; set; }
        public FrmAgregarEmpleado()
        {
            InitializeComponent();
        }

        private void FrmAgregarEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                numIdEmp.Text = Id_Empleado;
                txtNombreEmp.Text = Nombre;
                txtApellidoEmp.Text = Apellido;
                txtCedula.Text = Cedula;
                cbxTanda.Text = Tanda;
                fechaIngreso.Text = FechaIngreso;
                cbxEstado.Text = Estado;

                numIdEmp.Enabled = modo.Equals("C");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar " + ex.Message);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            void verificarCampos()
            {
                VerCampos(txtNombreEmp);
                VerCampos(txtApellidoEmp);
                VerCampos(txtUsuario);
                VerCampos(txtContrasena);
                //  VerCampos(txtCedula);
                if (!validaCedula(txtCedula.Text))
                {
                    MessageBox.Show("Cedula no valida");
                }

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
                            sql = "insert into Empleado Values ('";
                            sql += numIdEmp.Value + "','" + txtNombreEmp.Text + "','" + txtApellidoEmp.Text + "','" + txtCedula.Text + "','";
                            sql += cbxTanda.Text + "','" + fechaIngreso.Text + "','" + cbxEstado.Text + "','" + txtUsuario.Text + "','" + txtContrasena.Text + "')";
                        }
                        else
                        {
                            sql = " update Empleado set ";

                            sql += "Nombre = '" + numIdEmp.Text + "',";
                            sql += "Apellido = '" + txtApellidoEmp.Text + "',";
                            sql += "Cedula = '" + txtCedula.Text + "',";
                            sql += "NCarnet = '" + cbxTanda.Text + "',";
                            sql += "TipoUsuario = '" + fechaIngreso.Text + "',";
                            sql += "Estado = '" + cbxEstado.Text + "',";
                            sql += "NombreUrs = '" + txtUsuario.Text + "',";
                            sql += "Contrasena = '" + txtContrasena.Text + "',";



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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete Empleado";
                sql += " where Id_Empleado = '" + numIdEmp.Value + "'";
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
        //VALIDACION DE CEDULA
        public static bool validaCedula(string pCedula)

        {
            int vnTotal = 0;
            string vcCedula = pCedula.Replace("-", "");
            int pLongCed = vcCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
            }

            if (vnTotal % 10 == 0)
                return true;
            else
                return false;
        }

    }
}
