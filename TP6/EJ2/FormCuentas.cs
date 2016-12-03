﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EJ2.DTO;

namespace EJ2
{
    public partial class FormCuentas : Form
    {
        AccountManager iAM;

        public FormCuentas(AccountManager pAM)
        {
            InitializeComponent();
            iAM = pAM;

            tablaCuentas.DataSource = new List<AccountDTO> { };
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {


            int clientId;
            int.TryParse(txtIdCliente.Text, out clientId);

            double limite;
            double.TryParse(txtLimite.Text, out limite);

            AccountDTO account = new AccountDTO()
            {
                Name = txtNombre.Text,
                ClientId = clientId,
                OverdraftLimit = limite
            };

            try
            { 
                iAM.AgregarCuenta(account);
                MessageBox.Show("Cuenta agregada");
            }
            catch(InvalidOperationException)
            {
                MessageBox.Show("El cliente no existe");
            }
            catch(ArgumentException)
            {
                MessageBox.Show("Los datos ingresados son incorrectos.");
            }

            
        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(txtBuscarId.Text, out id);


            try
            {
                AccountDTO account = iAM.ObtenerCuenta(id);

                txtId.Text = account.Id.ToString();
                txtIdCliente.Text = account.ClientId.ToString();
                txtCliente.Text = account.ClientName;
                txtNombre.Text = account.Name;
                txtLimite.Text = account.OverdraftLimit.ToString();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No exsite una cuenta con el Id ingresado.");
            }  
            
        }



        private void btnVerTodas_Click(object sender, EventArgs e)
        {
            IEnumerable<AccountDTO> enuCli = iAM.ListaCuentas();

            tablaCuentas.DataSource = enuCli;
            tablaCuentas.Refresh();
        }



        private void btnObtSuperanLim_Click(object sender, EventArgs e)
        {
            IEnumerable<AccountDTO> enuCli = iAM.ObtenerCuentasSuperanDescubierto();

            tablaCuentas.DataSource = enuCli;
            tablaCuentas.Refresh();
        }


        private void btnDetalleYMov_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Debe buscar o seleccionar una cuenta primero");
                return;
            }

            int id;
            int.TryParse(txtId.Text, out id);


                new FormEstadoYMovimientos(iAM, id).ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Debe buscar o seleccionar una cuenta primero");
                return;
            }

            DialogResult res = MessageBox.Show("Esta seguro que desea actualizar los datos?", "Confimarcion", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                int id;
                int.TryParse(txtId.Text, out id);

                int clientId;
                int.TryParse(txtIdCliente.Text, out clientId);

                double limite;
                double.TryParse(txtLimite.Text, out limite);

                AccountDTO account = new AccountDTO()
                {
                    Id = id,
                    Name = txtNombre.Text,
                    ClientId = clientId,
                    OverdraftLimit = limite
                };

                iAM.ModificarCuenta(account);

                MessageBox.Show("Cuenta actualizada");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Debe buscar o seleccionar una cuenta primero");
                return;
            }

            DialogResult res = MessageBox.Show("Esta seguro que desea eliminar la cuenta con ID: " + txtId.Text + " ?", "Confimarcion", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                int id;
                int.TryParse(txtId.Text, out id);
                iAM.EliminarCuenta(id);

                MessageBox.Show("Cuenta eliminada");
            }
        }

        private void tablaCuentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = tablaCuentas.Rows[e.RowIndex];

            txtId.Text = row.Cells[0].Value.ToString();
            txtIdCliente.Text = row.Cells[3].Value.ToString();
            txtCliente.Text = row.Cells[4].Value.ToString();
            txtNombre.Text = row.Cells[1].Value.ToString();
            txtLimite.Text = row.Cells[2].Value.ToString();
        }
    }
}
