using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Distribuciòn;

namespace Distribuciòn
{
    public partial class InicioChofer : Form
    {
        public static InicioChofer frmInicioChofer;
        public InicioChofer()
        {
            InitializeComponent();
            frmInicioChofer = this; // Inicializa la instancia
        }

        private void btnLotesLlevar_Click(object sender, EventArgs e)
        {
            frmInicioChofer.Visible = (false);
            LotesALlevar frmLotesALlevar = new LotesALlevar();
            frmLotesALlevar.Show();
            frmLotesALlevar.FormClosed += (s, arg) => frmInicioChofer.Visible = (true);
        }
    }
}
