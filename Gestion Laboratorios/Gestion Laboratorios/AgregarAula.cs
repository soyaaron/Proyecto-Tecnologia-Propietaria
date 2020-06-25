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
    public partial class AgregarAula : Form
    {
        public Aula aula { get; set; }
        private Gestion_laboratoriosEntities entities = new Gestion_laboratoriosEntities();
        public AgregarAula()
        {
            InitializeComponent();
        }

        private void AgregarAula_Load(object sender, EventArgs e)
        {
            if (aula != null)
            {
                txtAula.Text = aula.Descripcion.ToString();
               // cbxEdificio = aula.IdEdificio.ToString();
               // cbxEstadoAulaReserv = aula.Estado.ToString();
               // cbxTipoAula = aula.IdTipoAula.ToString();


            }
        }

        private void BtnGuardarAula_Click(object sender, EventArgs e)
        {
            entities.Aula.Add(new Aula
                {
                Descripcion = txtAula.Text,
            } );
            entities.SaveChanges();
            MessageBox.Show("Datos guardado con exito");
            this.Close();
        }
    }
}
