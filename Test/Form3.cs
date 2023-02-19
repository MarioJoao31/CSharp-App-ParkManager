using SmartPark.Data;
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
    public partial class Form3 : Form
    {
        public static Users users;
        public Form3()
        {

            users = new Users();
            InitializeComponent();
        }

        private void bt_LugaresDisponiveis_Click(object sender, EventArgs e)
        {

        }
    }
}
