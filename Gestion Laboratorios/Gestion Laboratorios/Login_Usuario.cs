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
    public partial class Login_Usuario : Form
    {
        public Login_Usuario(string nombre)
        {
            InitializeComponent();
            lblmensaje.Text = nombre;
        }
    }
}
