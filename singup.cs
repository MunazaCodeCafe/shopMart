using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Data.SqlClient;

namespace shopMart
{
    public partial class singup : Form
    {
        string Pattren = "^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";
        string PassPattren = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public singup()
        {
            InitializeComponent();
        }
        private void nmetextBox1_Leave(object sender, EventArgs e)
        {
            if  (string.IsNullOrEmpty(nmetextBox1.Text)== true )
            {
                nmetextBox1.Focus(); 
                errorProvider1.SetError(this.nmetextBox1, "Fill the Field"); 
            }
            else
            {
                errorProvider1.Clear();
            }
                }
        private void nmetextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (Char.IsLetter(ch)==true)
            {
                e.Handled = false;
            }
            else if(ch==8)
                {
                e.Handled = false;
            }
            else
            {
                e.Handled = false;
            }


        }
        private void surnmetextBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(surnmetextBox2.Text) == true)
            {
                surnmetextBox2.Focus();
                errorProvider2.SetError(this.surnmetextBox2, "Fill the Field");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void surnmetextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = false;
            }
        }
        private void gendrcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gendrcomboBox1.Text) == true)
            {
                gendrcomboBox1.Focus();
                errorProvider3.SetError(this.gendrcomboBox1, "Fill the Field");
            }
            else
            {
                errorProvider3.Clear();
            }
        }
        private void addtextBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addtextBox3.Text) == true)
            {
                addtextBox3.Focus();
                errorProvider5.SetError(this.addtextBox3, "Fill the Field");
            }
            else
            {
                errorProvider5.Clear();
            }

        }

        private void addtextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = false;
            }
        }
        private void emaltextBox4_Leave(object sender, EventArgs e)
        {
            if(Regex.IsMatch(emaltextBox4.Text,Pattren)==false)
            {
                emaltextBox4.Focus(); 
                errorProvider6.SetError(this.emaltextBox4, "Enter valid email");
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void passtextBox5_Leave(object sender, EventArgs e)
        {
            if(Regex.IsMatch(passtextBox5.Text,PassPattren)== false)
            {
                passtextBox5.Focus();
                errorProvider7.SetError(this.passtextBox5, "Enter valid pass");
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void cnfrmpasstextBox6_Leave(object sender, EventArgs e)
        {
            if(passtextBox5.Text!= cnfrmpasstextBox6.Text)
            {
                cnfrmpasstextBox6.Focus();
                errorProvider8.SetError(this.cnfrmpasstextBox6, "Does not match");
            }
            else
            {
                errorProvider8.Clear();
            }
        }
        private void signbutton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nmetextBox1.Text) == true)
            {
                nmetextBox1.Focus();
                errorProvider1.SetError(this.nmetextBox1, "Fill the Field");
            }
            else if (string.IsNullOrEmpty(surnmetextBox2.Text) == true)
            {
                surnmetextBox2.Focus();
                errorProvider2.SetError(this.surnmetextBox2, "Fill the Field");
            }
            else if (string.IsNullOrEmpty(gendrcomboBox1.Text) == true)
            {
                gendrcomboBox1.Focus();
                errorProvider3.SetError(this.gendrcomboBox1, "Fill the Field");
            }
            else if (string.IsNullOrEmpty(addtextBox3.Text) == true)
            {
                addtextBox3.Focus();
                errorProvider5.SetError(this.addtextBox3, "Fill the Field");
            }
            else if (Regex.IsMatch(emaltextBox4.Text, Pattren) == false)
            {
                emaltextBox4.Focus();
                errorProvider6.SetError(this.emaltextBox4, "Enter valid email");
            }
           else if (Regex.IsMatch(passtextBox5.Text, PassPattren) == false)
            {
                passtextBox5.Focus();
                errorProvider7.SetError(this.passtextBox5, "Enter valid pass");
            }
            else if (passtextBox5.Text != cnfrmpasstextBox6.Text)
            {
                cnfrmpasstextBox6.Focus();
                errorProvider8.SetError(this.cnfrmpasstextBox6, "Does not match");
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "insert into sign_up values (@name, @surname, @gender,@age,@address,@email, @pass)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", nmetextBox1.Text);
                cmd.Parameters.AddWithValue("@surname", surnmetextBox2.Text);
                cmd.Parameters.AddWithValue("@gender", gendrcomboBox1.Text);
                cmd.Parameters.AddWithValue("@age", agenumericUpDown2.Text);
                cmd.Parameters.AddWithValue("@address", addtextBox3.Text);
                cmd.Parameters.AddWithValue("@email", emaltextBox4.Text);
                cmd.Parameters.AddWithValue("@pass", passtextBox5.Text);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Register Successfull", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("UserName is "+ nmetextBox1.Text+"\n \n "+"Password is "+ passtextBox5.Text, "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Login loginform = new Login();
                    loginform.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Register Fail", "fail", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                con.Close();
            }
        }
        private void reesetbutton2_Click(object sender, EventArgs e)
        {
            nmetextBox1.Clear();
            surnmetextBox2.Clear();
            gendrcomboBox1.SelectedItem= null;
            addtextBox3.Clear();
            agenumericUpDown2.Value = 0;
            emaltextBox4.Clear();
            passtextBox5.Clear();
            cnfrmpasstextBox6.Clear();
        }
        private void addtextBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void emaltextBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void singup_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void singup_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void NametextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
