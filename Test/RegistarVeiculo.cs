using SmartPark.Data;
using SmartPark.Enums;
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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test
{
    public partial class RegistarVeiculo : Form
    {
        static int idUser;
        public RegistarVeiculo()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        { 
            //var
            var selectedTipoEstatuto = this.comboBox1.SelectedItem.ToString();
            TipoVeiculo enumTipoVeiculo;
            Enum.TryParse<TipoVeiculo>(selectedTipoEstatuto, out enumTipoVeiculo);
            

            

            try
            {
                if (textBox1.Text == "")
                    MessageBox.Show("Tem q preencher todos os campos");

                
                Form1.veiculos.Add(new Veiculo(idUser, textBox1.Text, enumTipoVeiculo));
                textBox1.Text = "";
                comboBox1.Text = "";
                textBox1.Focus();
                MessageBox.Show("Registado com sucesso");
            }
            catch (Exception )
            {
                throw;
            }
            
            

        }

        private void RegistarVeiculo_Load(object sender, EventArgs e)
        {
            idUser = Form1.users.GetIdUserByEmail(RegisterUser.emailUser);

            //adds tipo polo e estatuto ao combobox
            comboBox1.Items.Add(TipoVeiculo.Mota);
            comboBox1.Items.Add(TipoVeiculo.Carro);

        }


    }
}
