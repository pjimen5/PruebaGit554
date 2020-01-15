using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace WFPrototipo
{
    
    public partial class Form1 : Form
    {
        // Estos son los cambios online en la forma 1
        List<Persona> personas = new List<Persona>();

        Persona persona = new Persona();
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

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateTimePicker1.Value = monthCalendar1.SelectionStart;
            dateTimePicker2.Value = monthCalendar1.SelectionEnd;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(Convert.ToInt32(textBox1.Text));
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Persona newPersona = new Persona(txtNombre.Text, txtLugar.Text);
            lbxPersonas.Items.Add((new Persona(txtNombre.Text,txtLugar.Text)).ImprimirPersona());
            personas.Add(newPersona);
            Console.WriteLine(newPersona.registrarPersona());

            DataTable dtPersonas = persona.listaPersonas();
            dataGridView1.DataSource = dtPersonas;
        }
        private void btnMSql_Click(object sender, EventArgs e)
        {
            DataTable dtPersonas = persona.listaPersonas();
            dataGridView1.DataSource = dtPersonas;

        }
        private DataTable ConvertListPersonaToDatatable() {
            DataTable table = new DataTable();

            int columns = 2; // nombre y lugar
            
            for (int i = 0; i < columns; i++)
            {
                table.Columns.Add();
            }

            // Add rows.
            foreach (var array in personas)
            {
              /*  List<String> celdas = new List<String>();
                celdas.Add(new string[] ({array.nombre,array.lugarNac}));
                DataRow dr = new DataRow();
                dr.a
                table.Rows.Add()
                table.Rows.Add(celdas);*/
            }

            return table;


        }

     

        private void btnMySQL_Click(object sender, EventArgs e)
        {
            DataTable dtPersonas = persona.listaPersonas2();
            dataGridView1.DataSource = dtPersonas;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // DataTable dtPersonas = persona.listaPersonas3();
            //dataGridView1.DataSource = dtPersonas;
        }
    }
}
