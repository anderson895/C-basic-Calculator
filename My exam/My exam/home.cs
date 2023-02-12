using System;

using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_exam
{
    public partial class home : Form
    {

        public string myconnection = "datasource=127.0.0.1;port=3306;username=root;password=;database=pdm";

        public home()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(myconnection);
            conn.Open();

            string query = "SELECT * from USERS";
            MySqlCommand asdas = new MySqlCommand(query, conn);
            MySqlDataAdapter DataAd = new MySqlDataAdapter();
            DataAd.SelectCommand = asdas;
            DataTable dataTab = new DataTable();
            DataAd.Fill(dataTab);
            asfasdfsadfsda.DataSource = dataTab;
        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }

        private void Asfasdfsadfsda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
