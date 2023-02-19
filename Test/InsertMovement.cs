using SmartPark.Data;
using SmartPark.Enums;
using SmartPark.Models;
using System;
using System.Collections;
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
    public partial class InsertMovement : Form
    {
        public InsertMovement()
        {
            InitializeComponent(); 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InsertMovement_Load(object sender, EventArgs e)
        {
            //put the parques in the comboboxes
            foreach (Parque parque in Form1.parques.GetParques())
            {

                //adds item in combobox
                comboBox2.Items.Add(parque.ParqueID);
            }

            //adds tipoMovimento ao combobox
            comboBox1.Items.Add(TipoMovimento.Entrada);
            comboBox1.Items.Add(TipoMovimento.Saida);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var
            var selectedTipoMovimento = this.comboBox1.SelectedItem.ToString();
            int selectedParque = Convert.ToInt32(this.comboBox2.SelectedItem.ToString()) ;
            
            //predicate 
            Predicate<int> validatePassword = Form1.parques.ExistsAvailableSpaces;


            //add to the list if tipoMovement = entrada
            if (selectedTipoMovimento == "Entrada")
            {
                //uso do predicate
                if (validatePassword(selectedParque))
                {
                    Form1.movements.Add(new Movement(textBox1.Text, DateTime.Now, TipoMovimento.Entrada, selectedParque));
                    Form1.parques.UpdateSpaces(selectedParque, -1);
                    MessageBox.Show("Movimento registado com Sucesso");
                }
                else
                {
                    MessageBox.Show("Movimento não registado, nao existe lugares disponiveis");
                }
               
            }
                
            if (selectedTipoMovimento == "Saida")
            {
                Form1.movements.Add(new Movement(textBox1.Text , DateTime.Now , TipoMovimento.Saida, selectedParque));
                Form1.parques.UpdateSpaces(selectedParque, 1);
                MessageBox.Show("Movimento registado com Sucesso");
            }

            
        }
    }
}