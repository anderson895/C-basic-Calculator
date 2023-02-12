using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
namespace My_exam
{
    public partial class singup : Form
    {
        public string myconnection = "datasource=127.0.0.1;port=3306;username=root;password=;database=pdm";

        public singup()
        {
            InitializeComponent();
        }

        private void Singup_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string Enusername = sdfasdfa.Text;
                string Enpassword = fasfasf.Text;
                string Enfullname = asdcvasdc.Text;
                string Enage = sadfafsaf.Text;
                string Engender = sdvasfsadfsa.Text;




                MySqlConnection conn = new MySqlConnection(myconnection);
                conn.Open();

                MySqlCommand dfskjgfsdh = new MySqlCommand("INSERT into USERS values (@username,@password,@fullname,@age,@gender )", conn);
                dfskjgfsdh.Parameters.AddWithValue("@username", sdfasdfa.Text);
                dfskjgfsdh.Parameters.AddWithValue("@password", fasfasf.Text);
                dfskjgfsdh.Parameters.AddWithValue("@fullname", asdcvasdc.Text);
                dfskjgfsdh.Parameters.AddWithValue("@age", int.Parse(sadfafsaf.Text));
                dfskjgfsdh.Parameters.AddWithValue("@gender", sdvasfsadfsa.Text);
                dfskjgfsdh.ExecuteNonQuery();




                login backtoLogin = new login();
                backtoLogin.Show();
                this.Dispose();

                conn.Close();
                MessageBox.Show("Success Registration !");

            }
            catch
            {
                MessageBox.Show("INVALID REGISTRATION OR WRONG FIELD TYPE !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login regisForm = new login();
            regisForm.Show();
            this.Dispose();
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

