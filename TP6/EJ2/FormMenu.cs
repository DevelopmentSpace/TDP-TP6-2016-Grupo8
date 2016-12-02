﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EJ2.Domain;
using EJ2.DTO;

namespace EJ2
{
    public partial class FormMenu : Form
    {
        AccountManager iAM;

        public FormMenu()
        {
            InitializeComponent();
            iAM = new AccountManager();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormClientes(iAM).ShowDialog();
        }

        private void gestionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCuentas(iAM).ShowDialog();
        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEstadoYMovimientos(iAM).ShowDialog();
        }
    }
}