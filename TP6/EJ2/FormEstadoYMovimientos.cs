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

        private void btnObtUltMov_Click(object sender, EventArgs e)
        {
            int cant;
            int.TryParse(txtCantMov.Text, out cant);

            IEnumerable<AccountMovementDTO> enuCli = iAM.ObtenerNMovimientos(iIdCuenta, cant);

            tablaMovimientos.DataSource = enuCli;
            tablaMovimientos.Refresh();
        }

        private void FormEstadoYMovimientos_Load(object sender, EventArgs e)
        {
            this.ActualizarBalance();
            txtIdCuenta.Text = iIdCuenta.ToString();
        }

        private void ActualizarBalance()
        {
           txtBalance.Text=iAM.ObtenerBalance(iIdCuenta).ToString();
        }

        private void btnAcreditar_Click(object sender, EventArgs e)
        {
            int monto;
            int.TryParse(txtMonto.Text, out monto);

            iAM.AgregarMovimiento(iIdCuenta, monto, txtDesc.Text);
            this.ActualizarBalance();
        }

        private void btnDebitar_Click(object sender, EventArgs e)
        {
            int monto;
            int.TryParse(txtMonto.Text, out monto);

            iAM.AgregarMovimiento(iIdCuenta, -monto, txtDesc.Text);
            this.ActualizarBalance();
        }
    }
}
