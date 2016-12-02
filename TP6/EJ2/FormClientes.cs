using EJ2.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ2
{
    public partial class FormClientes : Form
    {
        AccountManager iAM;

        public FormClientes(AccountManager pAM)
        {
            InitializeComponent();
            iAM = pAM;

            cbTipoDoc.Items.Add("DNI");
            cbTipoDoc.Items.Add("CUIL");
            cbTipoDoc.Items.Add("LC");
            cbTipoDoc.Items.Add("LE");

            cbTipoDoc.SelectedItem = "DNI";

            tablaClientes.DataSource = new List<ClientDTO> { };


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClientDTO client = new ClientDTO()
            {
                FirstName = txtNombre.Text,
                LastName = txtApellido.Text,
                NumberDocument = txtNumeroDoc.Text,
                TypeDocument = cbTipoDoc.SelectedIndex
            };

            iAM.AgregarCliente(client);
        }

        private void btnObtTodos_Click(object sender, EventArgs e)
        {
            IEnumerable<ClientDTO> enuCli = iAM.ListaClientes();

            tablaClientes.DataSource = enuCli;
            tablaClientes.Refresh();


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = (int)this.tablaClientes.SelectedRows[0].Cells[0].Value;
            DialogResult res = MessageBox.Show("Esta seguro que desea eliminar e cliente con ID: "+id.ToString()+" ?","Confimarcion",MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                iAM.EliminarCliente(id);
                this.btnObtTodos.PerformClick() ;
            }
                
        }

        private void tablaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = tablaClientes.Rows[e.RowIndex];

            //txtId = row.


        }
    }
}
