﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Laboratorios
{
    public partial class Login : Form
    {
        public SqlConnection con = null;
        public Login()
        {
            InitializeComponent();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {

            con = new SqlConnection("Data Source=AARONLAPTOP;Initial Catalog=Gestion_laboratorios;Integrated Security=True");
            con.Open();

            string contrasena = getcontrasena(txtcontrasena.Text);

            string sSQL = "select 'S' from Empleado where Estado = 'A' and Contrasena = '" + contrasena + "' and NombreUsr = '" + txtusuario.Text + "'";
            SqlCommand ocmd = new SqlCommand(sSQL, con);
            string sExiste = "";
            try
            {
                sExiste = ocmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                string sError = ex.Message;
            }

            if (!String.IsNullOrEmpty(sExiste))
            {
                PantPrincipal frmprn = new PantPrincipal();
                frmprn.Show();
                //this.Close();

            }
            else
            {
                MessageBox.Show("Clave incorrecta", "Error");
            }
        }
        public string getcontrasena(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }
        public void logear(string usuario, string contrasena) {

            try
            {
                con.open();
                sqlComand cmd = new sqlComand("SELECT Nombre, Tipo_usuario FROM usuarios WHERE Usuario = @usuarios AND Password = @pas", con);
                cmd.Parameters.AddWithValue("usuarios", usuario);
                cmd.Parameters.AddWithValue("pas", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Admin")
                    {
                        new Admin(dt.Rows[0][0].ToString()).Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "Usuario")
                    {
                        new Login_Usuario(dt.Rows[0][0].ToString()).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuarios y/o Contraseña Incorracta");
                }

            } catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
            logear(this.textBox1.text, this.textBox2.text);

        }
    }
}
