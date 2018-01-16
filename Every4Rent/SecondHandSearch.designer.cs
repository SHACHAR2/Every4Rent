using System.Windows.Forms;

namespace Every4Rent
{
    partial class SecondHandSearch
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
            this.type = new System.Windows.Forms.Label();
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
            this.CurrentConditionLabel = new System.Windows.Forms.Label();
            this.CurrentCondition = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.MaxPrice = new System.Windows.Forms.TextBox();
            this.MinPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.type.Location = new System.Drawing.Point(9, 402);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(35, 13);
            this.type.TabIndex = 16;
            this.type.Text = "Type";
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
            this.currnecy.Location = new System.Drawing.Point(107, 170);
            this.currnecy.Name = "currnecy";
            this.currnecy.Size = new System.Drawing.Size(121, 21);
            this.currnecy.TabIndex = 0;
            this.currnecy.Text = "Choose currency";
            this.currnecy.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(10, 178);
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
            this.MinimumPrice.Location = new System.Drawing.Point(10, 266);
            this.MinimumPrice.Name = "MinimumPrice";
            this.MinimumPrice.Size = new System.Drawing.Size(88, 13);
            this.MinimumPrice.TabIndex = 8;
            this.MinimumPrice.Text = "Minimum Price";
            // 
            // MaximunPrice
            // 
            this.MaximunPrice.AutoSize = true;
            this.MaximunPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MaximunPrice.Location = new System.Drawing.Point(10, 219);
            this.MaximunPrice.Name = "MaximunPrice";
            this.MaximunPrice.Size = new System.Drawing.Size(91, 13);
            this.MaximunPrice.TabIndex = 9;
            this.MaximunPrice.Text = "Maximum Price";
            // 
            // countryTxt
            // 
            this.countryTxt.Location = new System.Drawing.Point(107, 315);
            this.countryTxt.Name = "countryTxt";
            this.countryTxt.Size = new System.Drawing.Size(121, 20);
            this.countryTxt.TabIndex = 10;
            this.countryTxt.TextChanged += new System.EventHandler(this.countryTxt_TextChanged);
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.country.Location = new System.Drawing.Point(9, 318);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(49, 13);
            this.country.TabIndex = 11;
            this.country.Text = "country";
            // 
            // CurrentConditionLabel
            // 
            this.CurrentConditionLabel.AutoSize = true;
            this.CurrentConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CurrentConditionLabel.Location = new System.Drawing.Point(5, 363);
            this.CurrentConditionLabel.Name = "CurrentConditionLabel";
            this.CurrentConditionLabel.Size = new System.Drawing.Size(105, 13);
            this.CurrentConditionLabel.TabIndex = 12;
            this.CurrentConditionLabel.Text = "Current Condition";
            // 
            // CurrentCondition
            // 
            this.CurrentCondition.FormattingEnabled = true;
            this.CurrentCondition.Items.AddRange(new object[] {
            "Never used",
            "As good as new",
            "Used",
            "Require repair"});
            this.CurrentCondition.Location = new System.Drawing.Point(107, 360);
            this.CurrentCondition.Name = "CurrentCondition";
            this.CurrentCondition.Size = new System.Drawing.Size(121, 21);
            this.CurrentCondition.TabIndex = 13;
            this.CurrentCondition.Text = "Choose condition";
            this.CurrentCondition.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 399);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.MaxPrice.Location = new System.Drawing.Point(107, 219);
            this.MaxPrice.Name = "MaxPrice";
            this.MaxPrice.Size = new System.Drawing.Size(121, 20);
            this.MaxPrice.TabIndex = 23;
            this.MaxPrice.TextChanged += new System.EventHandler(this.MaxPrice_TextChanged);
            // 
            // MinPrice
            // 
            this.MinPrice.Location = new System.Drawing.Point(107, 263);
            this.MinPrice.Name = "MinPrice";
            this.MinPrice.Size = new System.Drawing.Size(121, 20);
            this.MinPrice.TabIndex = 24;
            this.MinPrice.TextChanged += new System.EventHandler(this.MinPrice_TextChanged);
            // 
            // SecondHandSearch
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 617);
            this.Controls.Add(this.MinPrice);
            this.Controls.Add(this.MaxPrice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CurrentCondition);
            this.Controls.Add(this.CurrentConditionLabel);
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
            this.Controls.Add(this.type);
            this.Name = "SecondHandSearch";
            this.Text = "Second-Hand Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label type;
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
        private System.Windows.Forms.Label CurrentConditionLabel;
        private System.Windows.Forms.ComboBox CurrentCondition;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox MaxPrice;
        private System.Windows.Forms.TextBox MinPrice;
    }
}