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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AulaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aulaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestion_laboratoriosDataSet);

        }

        private void AulaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.aulaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestion_laboratoriosDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestion_laboratoriosDataSet.Aula' table. You can move, or remove it, as needed.
            this.aulaTableAdapter.Fill(this.gestion_laboratoriosDataSet.Aula);

        }

        private void idAulaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idAulaLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
