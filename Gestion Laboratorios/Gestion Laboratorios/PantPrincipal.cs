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

        public Reservacion reserva { get; set; }
        private ReservEntities entities = new ReservEntities();

        public PantPrincipal()
        {
            InitializeComponent();
        }

        private void PantPrincipal_Load(object sender, EventArgs e)
        {
            consultarReservas();
        }

        private void consultarReservas()
        {
            dvgReservaciones.DataSource = entities.Reservacion.ToList();
        }

        private void ClickGestionCampus(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void btnDirigeAgregarRes(object sender, EventArgs e)
        {
            FrmReservacion frmres = new FrmReservacion();
            frmres.ShowDialog();
        }

        private void BtnBuscarReservas_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }
       private void consultarPorCriterio()
        {
            var reservacion = from em in entities.Reservacion
                              where (em.N_Reservacion.ToString().StartsWith(txtBuscar.Text) ||
                              em.Usuario.StartsWith(txtBuscar.Text) 
                              )
                              select em;
            dvgReservaciones.DataSource = reservacion.ToList();
        }

        private void PantPrincipal_Activado(object sender, EventArgs e)
        {
            consultarReservas();
        }

        private void dgvReserv_DobleClick(object sender,  EventArgs e)
        {
            DataGridViewRow row = this.dvgReservaciones.SelectedRows[0];
            Reservacion reserva = new Reservacion();
            reserva.N_Reservacion = Int32.Parse(row.Cells[0].Value.ToString());
            reserva.Usuario = row.Cells[2].Value.ToString();

            FrmReservacion frmRes = new FrmReservacion();
         //   frmRes.reserva = reserva;
            frmRes.ShowDialog();

        }
    }
}