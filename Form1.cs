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
    public partial class Form1 : Form
    {
        int FinalCost = 0;
        int Tax = 0;
        int Sr_no = 0;

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Form1() 
        {
            InitializeComponent();
            getinvoiceno();
            UsertextBox2.Text = Login.userName;
            GetItems();
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Sr No.";
            dataGridView1.Columns[1].Name = "Item Name";
            dataGridView1.Columns[2].Name = "Price";
            dataGridView1.Columns[3].Name = "Discount";
            dataGridView1.Columns[4].Name = "Quantity";
            dataGridView1.Columns[5].Name = "Sub Total";
            dataGridView1.Columns[6].Name = "Tax";
            dataGridView1.Columns[7].Name = "Total Cost";


        }
        //get items from sql table
        void GetItems()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from items_tbl";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string item_names = dr.GetString(1);
                ItemscomboBox1.Items.Add(item_names);
            }
            con.Close();
        }
        void GetPrice()
        {
            if (ItemscomboBox1.SelectedItem == null)
            {

            }
            else
            {
                int price = 0;
                SqlConnection con = new SqlConnection(cs);
                string query = "select item_pricce from items_tbl where item_name= @names";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@names", ItemscomboBox1.SelectedItem.ToString());
                DataTable data = new DataTable();
                sda.Fill(data);
                if (data.Rows.Count > 0)
                {
                    price = Convert.ToInt32(data.Rows[0]["item_pricce"]);
                }
                PricetextBox3.Text = price.ToString();
            }
        }
        void GetDiscount()
        {
            if (ItemscomboBox1.SelectedItem == null)
            {

            }
            else
            {
                int discount = 0;
                SqlConnection con = new SqlConnection(cs);
                string query = "select item_discount from items_tbl where item_name= @names";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@names", ItemscomboBox1.SelectedItem.ToString());
                DataTable data = new DataTable();
                sda.Fill(data);
                if (data.Rows.Count > 0)
                {
                    discount = Convert.ToInt32(data.Rows[0]["item_discount"]);
                }
                DiscounttextBox4.Text = discount.ToString();
            }
        }
        private void ItemscomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPrice();
            GetDiscount();
            QuantitytextBox5.Enabled = true;

        }
        private void QuantitytextBox5_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(QuantitytextBox5.Text) == true)
            {

            }
            else
            {
                int price = Convert.ToInt32(PricetextBox3.Text);
                int discount = Convert.ToInt32(DiscounttextBox4.Text);
                int quantity = Convert.ToInt32(QuantitytextBox5.Text);
                // price according to quantity and data comes from textboxes and calculate the doscount
                int subTotal = price * quantity;
                subTotal = subTotal - discount * quantity;
                SubTotaltextBox6.Text = subTotal.ToString();
            }
        }
        private void SubTotaltextBox6_TextChanged(object sender, EventArgs e)//controls ko use kar rhy hain
        {
            if (string.IsNullOrEmpty(SubTotaltextBox6.Text) == true)
            {

            }
            else
            {
                int subTotal = Convert.ToInt32(SubTotaltextBox6.Text);
                //calculate tax according to subTotal amount
                if (subTotal >= 5000)
                {
                    Tax = (int)(subTotal * 0.10);
                    TaxtextBox7.Text = Tax.ToString();
                }
                else if (subTotal >= 4000)
                {
                    Tax = (int)(subTotal * 0.9);
                    TaxtextBox7.Text = Tax.ToString();
                }
                else if (subTotal >= 3000)
                {
                    Tax = (int)(subTotal * 0.8);
                    TaxtextBox7.Text = Tax.ToString();
                }
                else if (subTotal >= 2000)
                {
                    Tax = (int)(subTotal * 0.7);
                    TaxtextBox7.Text = Tax.ToString();
                }
                else
                {
                    Tax = (int)(subTotal * 0.3);
                    TaxtextBox7.Text = Tax.ToString();
                }
            }

        }
        private void TaxtextBox7_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TaxtextBox7.Text) == true)
            {

            }
            else
            {
                int subTotal = Convert.ToInt32(SubTotaltextBox6.Text);
                int tax = Convert.ToInt32(TaxtextBox7.Text);
                int TotalCost = subTotal + Tax;
                TotalCosttextBox8.Text = TotalCost.ToString();
            }
        }
 
        void AddDataToGird(string Sr_no, string item_name, string price, string discount , string quantity , string subTotal, string tax, string totalcost )
        {
            string[] row = { Sr_no, item_name , price , discount , quantity, subTotal , tax , totalcost };
            dataGridView1.Rows.Add(row);
        }
        private void AddItembutton1_Click(object sender, EventArgs e)
        {
            try {
                AddDataToGird((++Sr_no).ToString(), ItemscomboBox1.SelectedItem.ToString(), PricetextBox3.Text, DiscounttextBox4.Text, QuantitytextBox5.Text, SubTotaltextBox6.Text, TaxtextBox7.Text, TotalCosttextBox8.Text);
                Reset();
                calculateFinalCost();
            }
            catch{
                MessageBox.Show("Login Faile !!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void Reset()
        {
            ItemscomboBox1.SelectedItem = null;
            PricetextBox3.Clear();
            DiscounttextBox4.Clear();
            QuantitytextBox5.Clear();
            SubTotaltextBox6.Clear();
            TaxtextBox7.Clear();
            TotalCosttextBox8.Clear();
            FinalCosttextBox9.Clear();
            AmountPaidtextBox10.Clear();
            ChangetextBox11.Clear();
            QuantitytextBox5.Enabled = false;

        }
        void calculateFinalCost()
        {
            for(int i=0; i< dataGridView1.Rows.Count;i++)
            {
                FinalCost = FinalCost + Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value);
            }
            FinalCosttextBox9.Text = FinalCost.ToString();

        }
        private void AmountPaidtextBox10_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AmountPaidtextBox10.Text) == true)
        {
        }
            else
            {
                int Amount = Convert.ToInt32(AmountPaidtextBox10.Text);
                int fCost = Convert.ToInt32(FinalCosttextBox9.Text);
                int Change = Amount - fCost;
                ChangetextBox11.Text = Change.ToString();
            }
                }
        private void Resetbutton2_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Clearbutton1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Sr_no = 0;
        }
        void getinvoiceno()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select invoice_no from Ordered";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            if(data.Rows.Count<1)
            {
                InvoicetextBox1.Text = "1";
            }
            else
            {
                string query2 = "select max(invoice_no) from order_master";
                SqlCommand cmd = new SqlCommand(query2, con);
                con.Open();
                int a = Convert.ToInt32(cmd.ExecuteScalar());
                a = a + 1;
                InvoicetextBox1.Text = a.ToString();
                con.Close();
            }
        }
        private void Insertbutton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                string query3 = "insert into order_master values(@invoice_id,@user_name, @date_time, @final_cost)";
                SqlCommand cmd = new SqlCommand(query3, con);
                cmd.Parameters.AddWithValue("@invoice_id", InvoicetextBox1.Text);
                cmd.Parameters.AddWithValue("@user_name", UsertextBox2.Text);
                cmd.Parameters.AddWithValue("@date_time", DateTime.Now.ToString());
                cmd.Parameters.AddWithValue("@final_cost", FinalCosttextBox9.Text);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Inserted Successfull", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getinvoiceno();
                    Reset();
                }
                else
                {
                    MessageBox.Show("Insertion Fail", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void QuantitytextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) == true)
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

        private void AmountPaidtextBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) == true)
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
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label8_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ChangetextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void TotalCosttextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }



        private void DiscounttextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PricetextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UsertextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void InvoicetextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        

        
    }
}

