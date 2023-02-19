namespace Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.bt_ListarUsers = new System.Windows.Forms.Button();
            this.bt_DeleteUser = new System.Windows.Forms.Button();
            this.listView4 = new System.Windows.Forms.ListView();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btGetMovByDay = new System.Windows.Forms.Button();
            this.dateTimePickerByDay = new System.Windows.Forms.DateTimePicker();
            this.listView5 = new System.Windows.Forms.ListView();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btGetUserByState = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btTotalVeiculos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get Movements by plate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(552, 204);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 51);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Get all Movements";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(183, 16);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 23);
            this.textBox3.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(183, 378);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Remove Parque";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(183, 342);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(165, 23);
            this.textBox4.TabIndex = 14;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 378);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Get all Parques";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(12, 407);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(543, 204);
            this.listView2.TabIndex = 12;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 342);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(165, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "Get Parques by name";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(389, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Insert Movement";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1077, 699);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 49);
            this.button3.TabIndex = 16;
            this.button3.Text = "Exprimentar o login ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(354, 378);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(165, 23);
            this.button8.TabIndex = 17;
            this.button8.Text = "Adicionar Parque";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // listView3
            // 
            this.listView3.Location = new System.Drawing.Point(615, 80);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(543, 204);
            this.listView3.TabIndex = 18;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // bt_ListarUsers
            // 
            this.bt_ListarUsers.Location = new System.Drawing.Point(615, 23);
            this.bt_ListarUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_ListarUsers.Name = "bt_ListarUsers";
            this.bt_ListarUsers.Size = new System.Drawing.Size(165, 23);
            this.bt_ListarUsers.TabIndex = 19;
            this.bt_ListarUsers.Text = "ListarUsers";
            this.bt_ListarUsers.UseVisualStyleBackColor = true;
            this.bt_ListarUsers.Click += new System.EventHandler(this.bt_ListarUsers_Click);
            // 
            // bt_DeleteUser
            // 
            this.bt_DeleteUser.Location = new System.Drawing.Point(615, 51);
            this.bt_DeleteUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_DeleteUser.Name = "bt_DeleteUser";
            this.bt_DeleteUser.Size = new System.Drawing.Size(165, 23);
            this.bt_DeleteUser.TabIndex = 20;
            this.bt_DeleteUser.Text = "Remove User";
            this.bt_DeleteUser.UseVisualStyleBackColor = true;
            this.bt_DeleteUser.Click += new System.EventHandler(this.bt_DeleteUser_Click);
            // 
            // listView4
            // 
            this.listView4.Location = new System.Drawing.Point(615, 407);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(543, 204);
            this.listView4.TabIndex = 21;
            this.listView4.UseCompatibleStateImageBehavior = false;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(615, 378);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(165, 23);
            this.button9.TabIndex = 22;
            this.button9.Text = "Listar Veiculos";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(786, 378);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(165, 23);
            this.button10.TabIndex = 23;
            this.button10.Text = "Remover Veiculos";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // btGetMovByDay
            // 
            this.btGetMovByDay.Location = new System.Drawing.Point(197, 51);
            this.btGetMovByDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGetMovByDay.Name = "btGetMovByDay";
            this.btGetMovByDay.Size = new System.Drawing.Size(167, 23);
            this.btGetMovByDay.TabIndex = 24;
            this.btGetMovByDay.Text = "Get all Movements By Day";
            this.btGetMovByDay.UseVisualStyleBackColor = true;
            this.btGetMovByDay.Click += new System.EventHandler(this.btGetMovByDay_Click);
            // 
            // dateTimePickerByDay
            // 
            this.dateTimePickerByDay.Location = new System.Drawing.Point(345, 15);
            this.dateTimePickerByDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerByDay.Name = "dateTimePickerByDay";
            this.dateTimePickerByDay.Size = new System.Drawing.Size(219, 23);
            this.dateTimePickerByDay.TabIndex = 25;
            // 
            // listView5
            // 
            this.listView5.Location = new System.Drawing.Point(12, 662);
            this.listView5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(476, 154);
            this.listView5.TabIndex = 24;
            this.listView5.UseCompatibleStateImageBehavior = false;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 634);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(151, 24);
            this.button11.TabIndex = 25;
            this.button11.Text = "Listar Reservas";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(169, 634);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(165, 24);
            this.button12.TabIndex = 26;
            this.button12.Text = "Adicionar Reservas";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // btGetUserByState
            // 
            this.btGetUserByState.Location = new System.Drawing.Point(880, 51);
            this.btGetUserByState.Name = "btGetUserByState";
            this.btGetUserByState.Size = new System.Drawing.Size(165, 23);
            this.btGetUserByState.TabIndex = 1;
            this.btGetUserByState.Text = "Get user by state";
            this.btGetUserByState.Click += new System.EventHandler(this.btGetUserByState_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(1051, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // btTotalVeiculos
            // 
            this.btTotalVeiculos.Location = new System.Drawing.Point(957, 378);
            this.btTotalVeiculos.Name = "btTotalVeiculos";
            this.btTotalVeiculos.Size = new System.Drawing.Size(165, 23);
            this.btTotalVeiculos.TabIndex = 29;
            this.btTotalVeiculos.Text = "Total Veiculos";
            this.btTotalVeiculos.UseVisualStyleBackColor = true;
            this.btTotalVeiculos.Click += new System.EventHandler(this.btTotalVeiculos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 923);
            this.Controls.Add(this.btTotalVeiculos);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btGetUserByState);
            this.Controls.Add(this.dateTimePickerByDay);
            this.Controls.Add(this.btGetMovByDay);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.listView5);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.bt_DeleteUser);
            this.Controls.Add(this.bt_ListarUsers);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private ListView listView1;
        private Button button4;
        private TextBox textBox3;
        private Button button5;
        private TextBox textBox4;
        private Button button6;
        private ListView listView2;
        private Button button7;
        private Button button2;
        private Button button3;
        private Button button8;
        private ListView listView3;
        private Button bt_ListarUsers;
        private Button bt_DeleteUser;
        private ListView listView4;
        private Button button9;
        private Button button10;
        private Button btGetMovByDay;
        private DateTimePicker dateTimePickerByDay;
        private ListView listView5;
        private Button button11;
        private Button button12;
        private Button btGetUserByState;
        private ComboBox comboBox1;
        private Button btTotalVeiculos;
    }
}