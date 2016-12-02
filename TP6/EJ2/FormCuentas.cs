using System;
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

            tablaClientes.DataSource = new List<AccountDTO> { };
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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

            iAM.AgregarCuenta(account);

            MessageBox.Show("Cuenta agregada.");
        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(txtBuscarId.Text, out id);

            AccountDTO account = iAM.ObtenerCuenta(id);

            txtId.Text = account.Id.ToString();
            txtIdCliente.Text = account.ClientId.ToString();
            txtCliente.Text = account.ClientName;
            txtNombre.Text = account.Name;
            txtLimite.Text = account.OverdraftLimit.ToString();
            
        }

        private void btnBuscarIdCliente_Click(object sender, EventArgs e)
        {
            IEnumerable<AccountDTO> enuCli = iAM.ListaCuentas();

            tablaClientes.DataSource = enuCli;
            tablaClientes.Refresh();
        }
    }
}
