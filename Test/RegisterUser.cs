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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test
{
    public partial class RegisterUser : Form
    {
        public static string emailUser;
        public RegisterUser()
        {
            
            InitializeComponent();
        }

        private void btRegisted_Click(object sender, EventArgs e)
        {
            //var
            var selectedTipoEstatuto = this.comboBox1.SelectedItem.ToString();
            TipoEstatuto enumTipoestatuto;
            var selectedTipoPolo = this.comboBox2.SelectedItem.ToString();
            TipoPolo enumTipoPolo;

            Enum.TryParse<TipoEstatuto>(selectedTipoEstatuto, out enumTipoestatuto);
            Enum.TryParse<TipoPolo>(selectedTipoPolo, out enumTipoPolo);
            

            //se for nullo
            if (txt_Name.Text == "" || txt_Email.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Todos os campos tem de tar preenchidos");
            }
            else
            {
                emailUser = txt_Email.Text;
                Form1.users.Add(new User(txt_Name.Text, txt_Email.Text, txt_Password.Text, 1, enumTipoestatuto, enumTipoPolo));
                MessageBox.Show("Inserido com sucesso");
                new RegistarVeiculo().Show();
                this.Hide();
            }
            

        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {
            //adds tipo polo e estatuto ao combobox
            comboBox1.Items.Add(TipoEstatuto.Aluno);
            comboBox1.Items.Add(TipoEstatuto.Professor);
            comboBox1.Items.Add(TipoEstatuto.Funcionario);

            comboBox2.Items.Add(TipoPolo.EST);
            comboBox2.Items.Add(TipoPolo.ESD);
            comboBox2.Items.Add(TipoPolo.ESG);
           
        }

        
    }
}
