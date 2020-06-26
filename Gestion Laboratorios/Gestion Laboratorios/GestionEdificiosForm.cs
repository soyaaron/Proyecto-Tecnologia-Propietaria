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
    public partial class GestionEdificiosForm : Form
    {
        public GestionEdificiosForm()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void GestionEdificiosForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestion_laboratoriosDataSet.Edificios' table. You can move, or remove it, as needed.
            this.edificiosTableAdapter.Fill(this.gestion_laboratoriosDataSet.Edificios);

        }
    }
}
