using System.Windows.Forms;

namespace Every4Rent
{
    partial class VehicleSearch
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
            this.currnecy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.MinimumPrice = new System.Windows.Forms.Label();
            this.MaximunPrice = new System.Windows.Forms.Label();
            this.countryTxt = new System.Windows.Forms.TextBox();
            this.country = new System.Windows.Forms.Label();
            this.productType = new System.Windows.Forms.Label();
            this.VehicleType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SeatsNum = new System.Windows.Forms.TextBox();
            this.manYear = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.manufacturerLA = new System.Windows.Forms.Label();
            this.manufacturerBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.MaxPrice = new System.Windows.Forms.TextBox();
            this.MinPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.colorTxt = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.Label();
            this.ModelTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // currnecy
            // 
            this.currnecy.FormattingEnabled = true;
            this.currnecy.Items.AddRange(new object[] {
            "AUD",
            "GBP",
            "EUR",
            "IDR",
            "HKD",
            "USD",
            "ILS",
            "DKK",
            "HUF"});
            this.currnecy.Location = new System.Drawing.Point(122, 161);
            this.currnecy.Name = "currnecy";
            this.currnecy.Size = new System.Drawing.Size(121, 21);
            this.currnecy.TabIndex = 0;
            this.currnecy.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.currnecy.Text = "Choose currency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(10, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Currency ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(25, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First availability date- ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(27, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last availability date-";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(28, 123);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // MinimumPrice
            // 
            this.MinimumPrice.AutoSize = true;
            this.MinimumPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MinimumPrice.Location = new System.Drawing.Point(10, 254);
            this.MinimumPrice.Name = "MinimumPrice";
            this.MinimumPrice.Size = new System.Drawing.Size(88, 13);
            this.MinimumPrice.TabIndex = 8;
            this.MinimumPrice.Text = "Minimum Price";
            // 
            // MaximunPrice
            // 
            this.MaximunPrice.AutoSize = true;
            this.MaximunPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MaximunPrice.Location = new System.Drawing.Point(10, 207);
            this.MaximunPrice.Name = "MaximunPrice";
            this.MaximunPrice.Size = new System.Drawing.Size(91, 13);
            this.MaximunPrice.TabIndex = 9;
            this.MaximunPrice.Text = "Maximum Price";
            // 
            // countryTxt
            // 
            this.countryTxt.Location = new System.Drawing.Point(122, 291);
            this.countryTxt.Name = "countryTxt";
            this.countryTxt.Size = new System.Drawing.Size(121, 20);
            this.countryTxt.TabIndex = 10;
            this.countryTxt.TextChanged += new System.EventHandler(this.countryTxt_TextChanged);
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.country.Location = new System.Drawing.Point(9, 291);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(49, 13);
            this.country.TabIndex = 11;
            this.country.Text = "country";
            // 
            // productType
            // 
            this.productType.AutoSize = true;
            this.productType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.productType.Location = new System.Drawing.Point(9, 336);
            this.productType.Name = "productType";
            this.productType.Size = new System.Drawing.Size(77, 13);
            this.productType.TabIndex = 12;
            this.productType.Text = "Vehicle type";
            // 
            // VehicleType
            // 
            this.VehicleType.FormattingEnabled = true;
            this.VehicleType.Items.AddRange(new object[] {
            "Two wheeled",
            "Private car",
            "Truck",
            "Bus"});
            this.VehicleType.Location = new System.Drawing.Point(122, 336);
            this.VehicleType.Name = "VehicleType";
            this.VehicleType.Size = new System.Drawing.Size(121, 21);
            this.VehicleType.TabIndex = 13;
            this.VehicleType.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.VehicleType.Text = "Choose type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(9, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Seats Number";
            // 
            // SeatsNum
            // 
            this.SeatsNum.Location = new System.Drawing.Point(122, 383);
            this.SeatsNum.Name = "SeatsNum";
            this.SeatsNum.Size = new System.Drawing.Size(121, 20);
            this.SeatsNum.TabIndex = 15;
            this.SeatsNum.TextChanged += new System.EventHandler(this.SeatsNum_TextChanged);
            // 
            // manYear
            // 
            this.manYear.AutoSize = true;
            this.manYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.manYear.Location = new System.Drawing.Point(9, 422);
            this.manYear.Name = "manYear";
            this.manYear.Size = new System.Drawing.Size(108, 13);
            this.manYear.TabIndex = 16;
            this.manYear.Text = "Manufacture Year";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 422);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // manufacturerLA
            // 
            this.manufacturerLA.AutoSize = true;
            this.manufacturerLA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.manufacturerLA.Location = new System.Drawing.Point(11, 459);
            this.manufacturerLA.Name = "manufacturerLA";
            this.manufacturerLA.Size = new System.Drawing.Size(82, 13);
            this.manufacturerLA.TabIndex = 18;
            this.manufacturerLA.Text = "Manufacturer";
            // 
            // manufacturerBox
            // 
            this.manufacturerBox.Location = new System.Drawing.Point(122, 459);
            this.manufacturerBox.Name = "manufacturerBox";
            this.manufacturerBox.Size = new System.Drawing.Size(121, 20);
            this.manufacturerBox.TabIndex = 19;
            this.manufacturerBox.TextChanged += new System.EventHandler(this.manufacturerBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(249, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 533);
            this.dataGridView1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MaxPrice
            // 
            this.MaxPrice.Location = new System.Drawing.Point(122, 210);
            this.MaxPrice.Name = "MaxPrice";
            this.MaxPrice.Size = new System.Drawing.Size(121, 20);
            this.MaxPrice.TabIndex = 23;
            this.MaxPrice.TextChanged += new System.EventHandler(this.MaxPrice_TextChanged);
            // 
            // MinPrice
            // 
            this.MinPrice.Location = new System.Drawing.Point(122, 254);
            this.MinPrice.Name = "MinPrice";
            this.MinPrice.Size = new System.Drawing.Size(121, 20);
            this.MinPrice.TabIndex = 24;
            this.MinPrice.TextChanged += new System.EventHandler(this.MinPrice_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(12, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Color";
            // 
            // colorTxt
            // 
            this.colorTxt.Location = new System.Drawing.Point(122, 490);
            this.colorTxt.Name = "colorTxt";
            this.colorTxt.Size = new System.Drawing.Size(121, 20);
            this.colorTxt.TabIndex = 26;
            this.colorTxt.TextChanged += new System.EventHandler(this.colorTxt_TextChanged);
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Model.Location = new System.Drawing.Point(12, 524);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(41, 13);
            this.Model.TabIndex = 27;
            this.Model.Text = "Model";
            // 
            // ModelTxt
            // 
            this.ModelTxt.Location = new System.Drawing.Point(122, 526);
            this.ModelTxt.Name = "ModelTxt";
            this.ModelTxt.Size = new System.Drawing.Size(121, 20);
            this.ModelTxt.TabIndex = 28;
            this.ModelTxt.TextChanged += new System.EventHandler(this.ModelTxt_TextChanged);
            // 
            // VehicleSearch
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 617);
            this.Controls.Add(this.ModelTxt);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.colorTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MinPrice);
            this.Controls.Add(this.MaxPrice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.manufacturerBox);
            this.Controls.Add(this.manufacturerLA);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.manYear);
            this.Controls.Add(this.SeatsNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VehicleType);
            this.Controls.Add(this.productType);
            this.Controls.Add(this.country);
            this.Controls.Add(this.countryTxt);
            this.Controls.Add(this.MaximunPrice);
            this.Controls.Add(this.MinimumPrice);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currnecy);
            this.Name = "VehicleSearch";
            this.Text = "Vehicle Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox currnecy;
        private System.Windows.Forms.Label MinimumPrice;
        private System.Windows.Forms.Label MaximunPrice;
        private System.Windows.Forms.TextBox countryTxt;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.Label productType;
        private System.Windows.Forms.ComboBox VehicleType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SeatsNum;
        private System.Windows.Forms.Label manYear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label manufacturerLA;
        private System.Windows.Forms.TextBox manufacturerBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox MaxPrice;
        private System.Windows.Forms.TextBox MinPrice;
        private Label label5;
        private TextBox colorTxt;
        private Label Model;
        private TextBox ModelTxt;
    }
}