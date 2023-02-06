using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace shopMart
{
    public partial class Login : Form
    {
        public static string userName = "";
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkBox1.Checked;

            switch(check)
            {
                case true:
                    passtextBox2.UseSystemPasswordChar = false;
                    break;

                default:
                    passtextBox2.UseSystemPasswordChar = true;
                    break;

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from sign_up where name = @user and pass=@pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", usertextBox1.Text);
            cmd.Parameters.AddWithValue("@pass", passtextBox2.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                MessageBox.Show("Login Successful !!","Succsefull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userName = usertextBox1.Text;
                this.Hide();
                Form1 mainForm = new Form1();
                mainForm.ShowDialog(); 
            }
            else
            {

                MessageBox.Show("Login Faile !!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            singup Su = new singup();
           this.Hide();
                Su.ShowDialog();
        }
    }
}
