using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribuciòn
{
    public partial class Almacen : Form
    {
        private bool formularioVisible = false;
        public Almacen()
        {
            InitializeComponent();

            lisLote.SelectedIndexChanged += lisLote_SelectedIndexChanged;
        }
        int Peso = 0;
        int Capacidad = 0;
        List<Control> elementos = new List<Control>();
        

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //instancia de lblPanel
            Label lblLote = new Label();
            lblLote.Text = "Lote" + (elementos.Count + 1)+": Peso = "+Peso+"  Capacidad = "+Capacidad ;
            lblLote.Location = new Point(10, 10 + (elementos.Count * 30));
            elementos.Add(lblLote);

            lisLote.Items.Add(lblLote.Text);
            Controls.Add(lblLote);
        }

        private void lisLote_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            // Obtener el índice del elemento seleccionado en el ListBox
            int selectedIndex = lisLote.SelectedIndex;


            // Verificar si se ha seleccionado un elemento válido
            if (selectedIndex >= 0 && !formularioVisible)
            {
                plantillaLote frmplantillaLote = new plantillaLote();
                frmplantillaLote.Text = "Lote" + (selectedIndex++);
                formularioVisible = true;
                frmplantillaLote.Show();
                formularioVisible = false;

            }
        }
    }
}
