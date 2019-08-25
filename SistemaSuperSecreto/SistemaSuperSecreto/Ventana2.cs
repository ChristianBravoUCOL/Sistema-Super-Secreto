using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSuperSecreto
{
    public partial class Ventana2 : Form
    {
        public Ventana2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int conteo = 0;
            string seleccion;

            if (chkC.Checked == true)
            {
                conteo++;
            }
            if (chkBasic.Checked== true)
            {
                conteo++;
            }
            if (rbTarjeta.Checked==true)
            {
                seleccion = "Tarjeta de Crédito";
            }
            else
            {
                seleccion = "PayPal";
            }
            MessageBox.Show("Ha seleccionado " + conteo + " cursos y su método de pago es mediante " + seleccion);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           this.Hide();
           Form1 formulario = new Form1();
           formulario.Visible = true;
        }
    }
}
