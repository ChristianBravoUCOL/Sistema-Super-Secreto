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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text=="juancho" && txtPassword.Text =="123tamarindo")
            {
                MessageBox.Show("Bienvenido Señor Don Juancho");
                this.Hide();//Minimizamos o escondemos el Form1
                Ventana2 CursosVentana = new Ventana2(); //Creamos el objeto Ventana2 (el segundo form)
                CursosVentana.Show(); //Llamamos al segundo form
                this.Visible = false;            
            }

            else
            {
                MessageBox.Show("Usuario y/o Contraseña no valido");
                txtUsuario.Text = ""; //Limpiamos los campos
                txtPassword.Text = "";
                txtUsuario.Focus(); //Ponemos el cursor en el primer Textbox
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); //Sale del programa
        }
    }
}
