using SmartPark.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test
{
    public partial class InserirReserva : Form
    {
        public InserirReserva()
        {
            InitializeComponent();
        }

        private void InserirReserva_Load(object sender, EventArgs e)
        {
            foreach (Parque parque in Form1.parques.GetParques())
            {
                //adds item in combobox
                comboBox1.Items.Add(parque.NomeParque);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var
            var selectedParqueName = this.comboBox1.SelectedItem.ToString();
            DateTime datePicked = dateTimePicker1.Value;

            Form1.reservas.Add(new Reserva(datePicked,textBox1.Text, selectedParqueName), Form1.users, Form1.parques);
        }
    }
}
