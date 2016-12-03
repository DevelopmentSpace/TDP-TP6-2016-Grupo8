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
    public partial class FormEstadoYMovimientos : Form
    {
        AccountManager iAM;
        int iIdCuenta;



        public FormEstadoYMovimientos(AccountManager pAM, int pIdCuenta)
        {
            InitializeComponent();

            iAM = pAM;
            iIdCuenta = pIdCuenta;
        }

        /// <summary>
        /// Muestra el balance de la cuenta en pantalla
        /// </summary>
        private void ActualizarBalance()
        {
            txtBalance.Text = iAM.ObtenerBalance(iIdCuenta).ToString();
        }

        private void FormEstadoYMovimientos_Load(object sender, EventArgs e)
        {
            this.ActualizarBalance();
            txtIdCuenta.Text = iIdCuenta.ToString();
        }

        // - Botones de la interfaz - //

        //Boton obtener ultimo movimiento
        private void btnObtUltMov_Click(object sender, EventArgs e)
        {
            int cant;
            int.TryParse(txtCantMov.Text, out cant);

            if (cant <= 0)
            {
                MessageBox.Show("Ingrese una cantidad mayor a 0");
                return;
            }

            IEnumerable<AccountMovementDTO> enuCli = iAM.ObtenerNMovimientos(iIdCuenta, cant);

            tablaMovimientos.DataSource = enuCli;
            tablaMovimientos.Refresh();
        }

        //Boton acreditar
        private void btnAcreditar_Click(object sender, EventArgs e)
        {
            double monto;
            double.TryParse(txtMonto.Text, out monto);

            if (monto == 0.0)
            {
                MessageBox.Show("Debes ingresar un monto");
            }
            else if (monto < 0.0)
            {
                MessageBox.Show("El monto no debe ser negativo");
            }
            else
            {
                iAM.AgregarMovimiento(iIdCuenta, monto, txtDesc.Text);
                this.ActualizarBalance();
                MessageBox.Show("La operacion se realizo exitosamente");
            }
        }

        //Boton debitar
        private void btnDebitar_Click(object sender, EventArgs e)
        {
            double monto;
            double.TryParse(txtMonto.Text, out monto);

            if (monto == 0.0)
            {
                MessageBox.Show("Debes ingresar un monto");
            }
            else if (monto < 0.0)
            {
                MessageBox.Show("El monto no debe ser negativo");
            }
            else
            {
                iAM.AgregarMovimiento(iIdCuenta, -monto, txtDesc.Text);
                this.ActualizarBalance();
                MessageBox.Show("La operacion se realizo exitosamente");
            }
        }
    }
}
