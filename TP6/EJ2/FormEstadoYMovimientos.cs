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



    }
}
