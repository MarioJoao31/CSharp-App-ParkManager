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

namespace Test
{
    public partial class InsertParque : Form
    {
        public InsertParque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("One of the boxes is empty");
            }
            else
            {
                Form1.parques.Add(new Parque(textBox1.Text, Convert.ToInt32(textBox2.Text)));
                MessageBox.Show("Parque adicionado!");
            }


        }
    }
}
