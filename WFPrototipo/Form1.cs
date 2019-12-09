using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFPrototipo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0 || txtLugar.Text.Length == 0)
                MessageBox.Show("Por favor ingrese información en Nombre y Lugar.","Prototipo ITIR554");       
            else
                lblSaludo.Text = "Hola " + txtNombre.Text + " de " + txtLugar.Text + "!";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtLugar.Clear();
            txtNombre.Clear();
            lblSaludo.Text = "";
        }


    }
}
