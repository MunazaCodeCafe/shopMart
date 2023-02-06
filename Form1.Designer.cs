namespace shopMart
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.InvoicetextBox1 = new System.Windows.Forms.TextBox();
            this.UsertextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ItemscomboBox1 = new System.Windows.Forms.ComboBox();
            this.PricetextBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DiscounttextBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.QuantitytextBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SubTotaltextBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TaxtextBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TotalCosttextBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.FinalCosttextBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AmountPaidtextBox10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ChangetextBox11 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.AddItembutton1 = new System.Windows.Forms.Button();
            this.Resetbutton2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Clearbutton1 = new System.Windows.Forms.Button();
            this.Insertbutton1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Invoice No.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // InvoicetextBox1
            // 
            this.InvoicetextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoicetextBox1.Location = new System.Drawing.Point(56, 42);
            this.InvoicetextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.InvoicetextBox1.Name = "InvoicetextBox1";
            this.InvoicetextBox1.ReadOnly = true;
            this.InvoicetextBox1.Size = new System.Drawing.Size(218, 26);
            this.InvoicetextBox1.TabIndex = 2;
            this.InvoicetextBox1.TextChanged += new System.EventHandler(this.InvoicetextBox1_TextChanged);
            // 
            // UsertextBox2
            // 
            this.UsertextBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsertextBox2.Location = new System.Drawing.Point(56, 103);
            this.UsertextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.UsertextBox2.Name = "UsertextBox2";
            this.UsertextBox2.ReadOnly = true;
            this.UsertextBox2.Size = new System.Drawing.Size(218, 26);
            this.UsertextBox2.TabIndex = 4;
            this.UsertextBox2.TextChanged += new System.EventHandler(this.UsertextBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "User";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select Item";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ItemscomboBox1
            // 
            this.ItemscomboBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemscomboBox1.FormattingEnabled = true;
            this.ItemscomboBox1.Location = new System.Drawing.Point(56, 162);
            this.ItemscomboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.ItemscomboBox1.Name = "ItemscomboBox1";
            this.ItemscomboBox1.Size = new System.Drawing.Size(218, 28);
            this.ItemscomboBox1.TabIndex = 0;
            this.ItemscomboBox1.SelectedIndexChanged += new System.EventHandler(this.ItemscomboBox1_SelectedIndexChanged);
            // 
            // PricetextBox3
            // 
            this.PricetextBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PricetextBox3.Location = new System.Drawing.Point(56, 217);
            this.PricetextBox3.Margin = new System.Windows.Forms.Padding(2);
            this.PricetextBox3.Name = "PricetextBox3";
            this.PricetextBox3.ReadOnly = true;
            this.PricetextBox3.Size = new System.Drawing.Size(218, 26);
            this.PricetextBox3.TabIndex = 1;
            this.PricetextBox3.TextChanged += new System.EventHandler(this.PricetextBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // DiscounttextBox4
            // 
            this.DiscounttextBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscounttextBox4.Location = new System.Drawing.Point(57, 275);
            this.DiscounttextBox4.Margin = new System.Windows.Forms.Padding(2);
            this.DiscounttextBox4.Name = "DiscounttextBox4";
            this.DiscounttextBox4.ReadOnly = true;
            this.DiscounttextBox4.Size = new System.Drawing.Size(217, 26);
            this.DiscounttextBox4.TabIndex = 2;
            this.DiscounttextBox4.TextChanged += new System.EventHandler(this.DiscounttextBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 255);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Discount Per Item";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // QuantitytextBox5
            // 
            this.QuantitytextBox5.Enabled = false;
            this.QuantitytextBox5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantitytextBox5.Location = new System.Drawing.Point(301, 42);
            this.QuantitytextBox5.Margin = new System.Windows.Forms.Padding(2);
            this.QuantitytextBox5.Name = "QuantitytextBox5";
            this.QuantitytextBox5.Size = new System.Drawing.Size(220, 26);
            this.QuantitytextBox5.TabIndex = 3;
            this.QuantitytextBox5.TextChanged += new System.EventHandler(this.QuantitytextBox5_TextChanged);
            this.QuantitytextBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantitytextBox5_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(297, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Quantity";
            // 
            // SubTotaltextBox6
            // 
            this.SubTotaltextBox6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotaltextBox6.Location = new System.Drawing.Point(301, 103);
            this.SubTotaltextBox6.Margin = new System.Windows.Forms.Padding(2);
            this.SubTotaltextBox6.Name = "SubTotaltextBox6";
            this.SubTotaltextBox6.ReadOnly = true;
            this.SubTotaltextBox6.Size = new System.Drawing.Size(220, 26);
            this.SubTotaltextBox6.TabIndex = 4;
            this.SubTotaltextBox6.TextChanged += new System.EventHandler(this.SubTotaltextBox6_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(297, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Sub Total";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // TaxtextBox7
            // 
            this.TaxtextBox7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxtextBox7.Location = new System.Drawing.Point(301, 157);
            this.TaxtextBox7.Margin = new System.Windows.Forms.Padding(2);
            this.TaxtextBox7.Name = "TaxtextBox7";
            this.TaxtextBox7.ReadOnly = true;
            this.TaxtextBox7.Size = new System.Drawing.Size(220, 26);
            this.TaxtextBox7.TabIndex = 5;
            this.TaxtextBox7.TextChanged += new System.EventHandler(this.TaxtextBox7_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(297, 135);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tax";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // TotalCosttextBox8
            // 
            this.TotalCosttextBox8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCosttextBox8.Location = new System.Drawing.Point(301, 217);
            this.TotalCosttextBox8.Margin = new System.Windows.Forms.Padding(2);
            this.TotalCosttextBox8.Name = "TotalCosttextBox8";
            this.TotalCosttextBox8.ReadOnly = true;
            this.TotalCosttextBox8.Size = new System.Drawing.Size(220, 26);
            this.TotalCosttextBox8.TabIndex = 6;
            this.TotalCosttextBox8.TextChanged += new System.EventHandler(this.TotalCosttextBox8_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(297, 195);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Total Cost";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // FinalCosttextBox9
            // 
            this.FinalCosttextBox9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalCosttextBox9.Location = new System.Drawing.Point(301, 277);
            this.FinalCosttextBox9.Margin = new System.Windows.Forms.Padding(2);
            this.FinalCosttextBox9.Name = "FinalCosttextBox9";
            this.FinalCosttextBox9.ReadOnly = true;
            this.FinalCosttextBox9.Size = new System.Drawing.Size(220, 26);
            this.FinalCosttextBox9.TabIndex = 7;
            this.FinalCosttextBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(297, 255);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Final Cost";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // AmountPaidtextBox10
            // 
            this.AmountPaidtextBox10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountPaidtextBox10.Location = new System.Drawing.Point(61, 342);
            this.AmountPaidtextBox10.Margin = new System.Windows.Forms.Padding(2);
            this.AmountPaidtextBox10.Name = "AmountPaidtextBox10";
            this.AmountPaidtextBox10.Size = new System.Drawing.Size(213, 26);
            this.AmountPaidtextBox10.TabIndex = 8;
            this.AmountPaidtextBox10.TextChanged += new System.EventHandler(this.AmountPaidtextBox10_TextChanged);
            this.AmountPaidtextBox10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountPaidtextBox10_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(57, 320);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Amount Paid";
            // 
            // ChangetextBox11
            // 
            this.ChangetextBox11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangetextBox11.Location = new System.Drawing.Point(301, 342);
            this.ChangetextBox11.Margin = new System.Windows.Forms.Padding(2);
            this.ChangetextBox11.Name = "ChangetextBox11";
            this.ChangetextBox11.ReadOnly = true;
            this.ChangetextBox11.Size = new System.Drawing.Size(220, 26);
            this.ChangetextBox11.TabIndex = 9;
            this.ChangetextBox11.TextChanged += new System.EventHandler(this.ChangetextBox11_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(302, 320);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Change";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // AddItembutton1
            // 
            this.AddItembutton1.BackColor = System.Drawing.Color.Goldenrod;
            this.AddItembutton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItembutton1.Location = new System.Drawing.Point(543, 320);
            this.AddItembutton1.Margin = new System.Windows.Forms.Padding(2);
            this.AddItembutton1.Name = "AddItembutton1";
            this.AddItembutton1.Size = new System.Drawing.Size(83, 42);
            this.AddItembutton1.TabIndex = 25;
            this.AddItembutton1.Text = "Add";
            this.AddItembutton1.UseVisualStyleBackColor = false;
            this.AddItembutton1.Click += new System.EventHandler(this.AddItembutton1_Click);
            // 
            // Resetbutton2
            // 
            this.Resetbutton2.BackColor = System.Drawing.Color.Goldenrod;
            this.Resetbutton2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetbutton2.Location = new System.Drawing.Point(714, 320);
            this.Resetbutton2.Margin = new System.Windows.Forms.Padding(2);
            this.Resetbutton2.Name = "Resetbutton2";
            this.Resetbutton2.Size = new System.Drawing.Size(80, 42);
            this.Resetbutton2.TabIndex = 26;
            this.Resetbutton2.Text = "Reset";
            this.Resetbutton2.UseVisualStyleBackColor = false;
            this.Resetbutton2.Click += new System.EventHandler(this.Resetbutton2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 387);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 146);
            this.dataGridView1.TabIndex = 27;
            // 
            // Clearbutton1
            // 
            this.Clearbutton1.BackColor = System.Drawing.Color.Goldenrod;
            this.Clearbutton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbutton1.Location = new System.Drawing.Point(728, 554);
            this.Clearbutton1.Name = "Clearbutton1";
            this.Clearbutton1.Size = new System.Drawing.Size(85, 41);
            this.Clearbutton1.TabIndex = 29;
            this.Clearbutton1.Text = "Clear List";
            this.Clearbutton1.UseVisualStyleBackColor = false;
            this.Clearbutton1.Click += new System.EventHandler(this.Clearbutton1_Click);
            // 
            // Insertbutton1
            // 
            this.Insertbutton1.BackColor = System.Drawing.Color.Goldenrod;
            this.Insertbutton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insertbutton1.Location = new System.Drawing.Point(630, 320);
            this.Insertbutton1.Margin = new System.Windows.Forms.Padding(2);
            this.Insertbutton1.Name = "Insertbutton1";
            this.Insertbutton1.Size = new System.Drawing.Size(80, 42);
            this.Insertbutton1.TabIndex = 26;
            this.Insertbutton1.Text = "Insert";
            this.Insertbutton1.UseVisualStyleBackColor = false;
            this.Insertbutton1.Click += new System.EventHandler(this.Insertbutton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(557, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(837, 601);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Clearbutton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Insertbutton1);
            this.Controls.Add(this.Resetbutton2);
            this.Controls.Add(this.AddItembutton1);
            this.Controls.Add(this.ChangetextBox11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.AmountPaidtextBox10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.FinalCosttextBox9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TotalCosttextBox8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TaxtextBox7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SubTotaltextBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.QuantitytextBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DiscounttextBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PricetextBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ItemscomboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UsertextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InvoicetextBox1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InvoicetextBox1;
        private System.Windows.Forms.TextBox UsertextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ItemscomboBox1;
        private System.Windows.Forms.TextBox PricetextBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DiscounttextBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox QuantitytextBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SubTotaltextBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TaxtextBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TotalCosttextBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox FinalCosttextBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox AmountPaidtextBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ChangetextBox11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button AddItembutton1;
        private System.Windows.Forms.Button Resetbutton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Clearbutton1;
        private System.Windows.Forms.Button Insertbutton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

