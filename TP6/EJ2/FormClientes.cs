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
                TypeDocument = cbTipoDoc.SelectedItem.ToString()
            };
     
            try
            {
                iAM.AgregarCliente(client);
                MessageBox.Show("Cuenta agregada");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("El cliente ya existe");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Los datos ingresados son incorrectos.");
            }

            MessageBox.Show("Cliente agregado");
        }


        private void btnObtTodos_Click(object sender, EventArgs e)
        {
            IEnumerable<ClientDTO> enuCli = iAM.ListaClientes();

            tablaClientes.DataSource = enuCli;
            tablaClientes.Refresh();


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
 
            DialogResult res = MessageBox.Show("Esta seguro que desea eliminar el cliente con ID: "+txtId.Text+" ?","Confimarcion",MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                int id;
                int.TryParse(txtId.Text, out id);
                iAM.EliminarCliente(id);

                MessageBox.Show("Cliente eliminado");
            }
                
        }

        private void tablaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = tablaClientes.Rows[e.RowIndex];

            txtId.Text = row.Cells[0].Value.ToString();
            txtNombre.Text = row.Cells[3].Value.ToString();
            txtApellido.Text = row.Cells[4].Value.ToString();
            txtNumeroDoc.Text = row.Cells[2].Value.ToString();
            cbTipoDoc.SelectedItem = row.Cells[1].Value.ToString();
    }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(txtBuscar.Text, out id);

            ClientDTO cliente = iAM.ObtenerCliente(id);

            txtId.Text = cliente.Id.ToString();
            txtNombre.Text = cliente.FirstName;
            txtApellido.Text = cliente.LastName;
            txtNumeroDoc.Text = cliente.NumberDocument;
            cbTipoDoc.SelectedItem = cliente.TypeDocument;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Esta seguro que desea actualizar los datos?", "Confimarcion", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                int id;
                int.TryParse(txtId.Text, out id);

                ClientDTO client = new ClientDTO()
                {
                    Id = id,
                    FirstName = txtNombre.Text,
                    LastName = txtApellido.Text,
                    NumberDocument = txtNumeroDoc.Text,
                    TypeDocument = (string)cbTipoDoc.SelectedItem
                };

                iAM.ModificarCliente(client);

                MessageBox.Show("Cliente actualizado");
            }
        }
    }
}
