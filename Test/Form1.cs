using Microsoft.VisualBasic;
using SmartPark.Data;
using SmartPark.Enums;
using SmartPark.Exceptions;
using SmartPark.Models;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Test
{
    public partial class Form1 : Form
    {
        //variables assim posso acessar nos outros forms 
        public static Movements movements; 
        public static Parques parques;
        public static Users users;
        public static Veiculos veiculos;
        public static Reservas reservas;


        public Form1()
        {
            //criar as listas 
            movements = new Movements();
            parques = new Parques();
            users = new Users();
            veiculos = new Veiculos();
            reservas = new Reservas();
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clears listview and refreshes
            listView1.Items.Clear();
            listView1.Refresh();

            foreach (var movement in movements.GetMovementsbyPlate(textBox3.Text))
            {
                //Add item in the listview
                string[] arr = new string[4];
                ListViewItem item;

                //Add  item
                arr[0] = movement.Matricula;
                arr[1] = Convert.ToString(movement.DataMovimento) ;
                arr[2] = Convert.ToString(movement.TipoMovimento);
                arr[3] = Convert.ToString(movement.ParqueID);

                //adds to the listview
                item = new ListViewItem(arr);
                listView1.Items.Add(item);
            }

        }
 
        private void button4_Click(object sender, EventArgs e)
        {
            //clears listview and refreshes
            listView1.Items.Clear();
            listView1.Refresh();

            foreach (var movement in movements.GetMovements())
            {
                //Add item in the listview
                string[] arr = new string[4];
                ListViewItem item;

                //Add  item
                arr[0] = movement.Matricula;
                arr[1] = Convert.ToString(movement.DataMovimento);
                arr[2] = Convert.ToString(movement.TipoMovimento);
                arr[3] = Convert.ToString(movement.ParqueID);

                //adds to the listview
                item = new ListViewItem(arr);
                listView1.Items.Add(item);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
  
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //criar colunas na listview1 
            //moviments
            listView1.Columns.Add("Matricula", 120);
            listView1.Columns.Add("Data", 120);
            listView1.Columns.Add("TipoMovimento", 120);
            listView1.Columns.Add("Idparque", 120);

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            //parques
            listView2.Columns.Add("ParqueID", 120);
            listView2.Columns.Add("NomeParque", 120);
            listView2.Columns.Add("AvailablePlaces", 120);
            listView2.Columns.Add("TotalPlaces", 120);
                    
            listView2.View = View.Details;
            listView2.GridLines = true;
            listView2.FullRowSelect = true;

            //Users
            listView3.Columns.Add("UserId", 120);
            listView3.Columns.Add("Nome", 120);
            listView3.Columns.Add("Email", 120);
            listView3.Columns.Add("Tipo Estatuto", 120);
            listView3.Columns.Add("Polo preferencial", 120);
            

            listView3.View = View.Details;
            listView3.GridLines = true;
            listView3.FullRowSelect = true;

            //veiculos
            listView4.Columns.Add("IdUserMatricula", 120);
            listView4.Columns.Add("Matricula", 120);
            listView4.Columns.Add("TipoVeiculo", 120);

            listView4.View = View.Details;
            listView4.GridLines = true;
            listView4.FullRowSelect = true;

            //reservas
            listView5.Columns.Add("ReservaId", 120);
            listView5.Columns.Add("Data Reserva", 120);
            listView5.Columns.Add("Email do User", 120);
            listView5.Columns.Add("Nome do parque", 120);
                    
            listView5.View = View.Details;
            listView5.GridLines = true;
            listView5.FullRowSelect = true;

            comboBox1.Items.Add(TipoEstatuto.Aluno);
            comboBox1.Items.Add(TipoEstatuto.Professor);
            comboBox1.Items.Add(TipoEstatuto.Funcionario);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //var 
            int removerParqueInt = 0;
            bool isInt;
            //input box 
            string removerParque = Interaction.InputBox("Id do parque que deseja remover:","Remover Parque");

            //see if can convert to int convert to int and  
            isInt = int.TryParse(removerParque, out removerParqueInt);

            //if int remove parque 
            if (isInt)            
                parques.Remove(removerParqueInt);
            else
                MessageBox.Show("Parque não eliminado");
        }   
            
        private void button6_Click(object sender, EventArgs e)
        {
            //clears listview and refreshes
            listView2.Items.Clear();
            listView2.Refresh();

            foreach (var parque in parques.GetParques())
            {
                //Add item in the listview
                string[] arr = new string[4];
                ListViewItem item;

                //Add  item
                arr[0] = Convert.ToString(parque.ParqueID);
                arr[1] = parque.NomeParque;
                arr[2] = Convert.ToString(parque.AvailablePlaces);
                arr[3] = Convert.ToString(parque.TotalPlaces);

                //adds to the listview
                item = new ListViewItem(arr);
                listView2.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertMovement insertMovement = new InsertMovement();
            insertMovement.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new InsertParque().Show();

        }

        private void bt_ListarUsers_Click(object sender, EventArgs e)
        {
            listView3.Items.Clear();
            listView3.Refresh();

            foreach (var user in users.GetUsers())
            {
                //Add item in the listview
                string[] arr = new string[5];
                ListViewItem item;

                //Add  item

                arr[0] = Convert.ToString(user.IdUser);
                arr[1] = user.Name;
                arr[2] = user.Email;
                arr[3] = Convert.ToString(user.StatusDescription);
                arr[4] = Convert.ToString(user.PreferencePolo);


                //adds to the listview
                item = new ListViewItem(arr);
                listView3.Items.Add(item);
            }
        }

        private void bt_DeleteUser_Click(object sender, EventArgs e)
        {
            //var 
            int removerIdUser = 0;
            bool isInt;
            //input box 
            string removerUser = Interaction.InputBox("Id do user que deseja remover:", "Remover User");

            //see if can convert to int convert to int and  
            isInt = int.TryParse(removerUser, out removerIdUser);

            //if int remove parque 
            if (isInt)
                users.Delete(removerIdUser);
            else
                MessageBox.Show("User não eliminado");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listView4.Items.Clear();
            listView4.Refresh();

            foreach (Veiculo veiculo in veiculos.List())
            {
                //Add item in the listview
                string[] arr = new string[3];
                ListViewItem item;

                //Add  item
                arr[0] = Convert.ToString(veiculo.IdUserMatricula);
                arr[1] = veiculo.Matricula;
                arr[2] = Convert.ToString(veiculo.TipoVeiculo);

                //adds to the listview
                item = new ListViewItem(arr);
                listView4.Items.Add(item);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //var
            int _removerVeiculoUserId = 0;
            bool isInt;

            //input box 
            string removerVeiculoMatricula = Interaction.InputBox("Matricula que deseja remover:", "Remover Veiculo");
            string removerVeiculoUserId = Interaction.InputBox("Id do User veiculo que deseja remover:", "Remover Veiculo");

            //see if can convert to int convert to int and  
            isInt = int.TryParse(removerVeiculoUserId, out _removerVeiculoUserId);

            //if int remove parque 
            if (isInt)
                veiculos.Delete(removerVeiculoMatricula, _removerVeiculoUserId);
            else
                MessageBox.Show("Veiculo não eliminado");
        }

        private void btGetMovByDay_Click(object sender, EventArgs e)
        {
            //clears listview and refreshes
            listView1.Items.Clear();
            listView1.Refresh();

            foreach (var movement in movements.GetMovementsByDay(dateTimePickerByDay.Value))
            {
                //Add item in the listview
                string[] arr = new string[4];
                ListViewItem item;

                //Add  item
                arr[0] = movement.Matricula;
                arr[1] = Convert.ToString(movement.DataMovimento);
                arr[2] = Convert.ToString(movement.TipoMovimento);
                arr[3] = Convert.ToString(movement.ParqueID);

                //adds to the listview
                item = new ListViewItem(arr);
                listView1.Items.Add(item);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new InserirReserva().Show();
        }

        private void btGetUserByState_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //clears listview and refreshes
            listView5.Items.Clear();
            listView5.Refresh();

            foreach (Reserva reserva in reservas.GetReservas())
            {
                //Add item in the listview
                string[] arr = new string[4];
                ListViewItem item;

                //Add  item
                arr[0] = Convert.ToString(reserva.ReservaId);
                arr[1] = Convert.ToString(reserva.DateReserva);
                arr[2] = Convert.ToString(reserva.UserEmailReserva);
                arr[3] = Convert.ToString(reserva.NomeParqueReserva);

                //adds to the listview
                item = new ListViewItem(arr);
                listView5.Items.Add(item);
            }
        }

        private void btGetUserByState_Click_1(object sender, EventArgs e)
        {
            //clears listview and refreshes
            listView3.Items.Clear();
            listView3.Refresh();

            //passar enum to string
            var selectedTipoEstatuto = this.comboBox1.SelectedItem.ToString();
            TipoEstatuto enumTipoestatuto;
            Enum.TryParse<TipoEstatuto>(selectedTipoEstatuto, out enumTipoestatuto);

            //bug: nao aceita a combo box depois verificar
            foreach (var user in users.GetUserByState(enumTipoestatuto))
            {
                //Add item in the listview
                string[] arr = new string[5];
                ListViewItem item;

                //Add  item

                arr[0] = Convert.ToString(user.IdUser);
                arr[1] = user.Name;
                arr[2] = user.Email;
                arr[3] = Convert.ToString(user.StatusDescription);
                arr[4] = Convert.ToString(user.PreferencePolo);


                //adds to the listview
                item = new ListViewItem(arr);
                listView3.Items.Add(item);
            }
        }

        private void btTotalVeiculos_Click(object sender, EventArgs e)
        {
            //clears listview and refreshes
            listView4.Items.Clear();
            listView4.Refresh();

            MessageBox.Show($"Existem {veiculos.TotalVeiculos()} no Total");
            
        }
    }
}