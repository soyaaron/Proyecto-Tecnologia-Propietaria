﻿using System;
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
    public partial class PantPrincipal : Form
    {
        public PantPrincipal()
        {
            InitializeComponent();
        }

        private void PantPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void ClickGestionCampus(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void btnDirigeAgregarRes(object sender, EventArgs e)
        {
            FrmReservacion frmres = new FrmReservacion();
            frmres.Show();
        }
    }
}
