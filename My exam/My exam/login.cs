using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace My_exam
{
    public partial class login : Form
    {
        public string myconnection = "datasource=127.0.0.1;port=3306;username=root;password=;database=pdm";

        public login()
        {
            InitializeComponent();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            string username = textBox1.Text;
            string password = textBox2.Text;
            string Username = "";
            string Password = "";



            MySqlConnection conn = new MySqlConnection(myconnection);
            conn.Open();

            string query = "select * from users where username='" + username + "'and password='" + password + "';";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                Username = dr["username"].ToString();
                Password = dr["password"].ToString();

            }


            if (!dr.HasRows)
            {

                MessageBox.Show("WRONG USERNAME OR PASSWORD", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Welcome :" + Username + "", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                home mainForm = new home();
                mainForm.Show();
                this.Dispose();
            }




            conn.Close();


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            {
                singup regisForm = new singup();
                regisForm.Show();
                this.Dispose();
            }
        }

        private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
