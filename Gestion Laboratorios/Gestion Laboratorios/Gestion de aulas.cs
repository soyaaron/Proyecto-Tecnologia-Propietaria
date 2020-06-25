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
    public partial class FrmGestionAulas : Form
    {
        public Aula aula { get; set; }
        private Gestion_laboratoriosEntities entities = new Gestion_laboratoriosEntities();

        public FrmGestionAulas()
        {
            InitializeComponent();
        }

        private void FrmGestionAulas_Load(object sender, EventArgs e)
        {

            consultarAulas();

        }
        private void consultarAulas()
        {
            dgvAulas.DataSource = entities.Aula.ToList();
        }

        private void DirigirAgregarAula(object sender, EventArgs e)
        {
            AgregarAula getaddau = new AgregarAula ();
            getaddau.ShowDialog();
        }

        private void dgvdoubleclick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvAulas.SelectedRows[0];
            Aula aula = new Aula();
            aula.IdAula = Int32.Parse(row.Cells[0].Value.ToString());
            aula.Descripcion = row.Cells[1].Value.ToString();

            AgregarAula frmagaula = new AgregarAula();
            frmagaula.aula = aula;
            frmagaula.ShowDialog();
        }
    }
}
