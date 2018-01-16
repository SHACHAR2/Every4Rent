using System.Windows;

namespace Every4Rent
{
    partial class Everything4rent
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.personalArea = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.RealEstate = new System.Windows.Forms.Button();
            this.SecondHend = new System.Windows.Forms.Button();
            this.Vehicle = new System.Windows.Forms.Button();
            this.Pet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(3, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sign In ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Create Account";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "don\'t have an account?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // personalArea
            // 
            this.personalArea.Location = new System.Drawing.Point(1133, 26);
            this.personalArea.Name = "personalArea";
            this.personalArea.Size = new System.Drawing.Size(131, 23);
            this.personalArea.TabIndex = 3;
            this.personalArea.Text = "personal area";
            this.personalArea.UseVisualStyleBackColor = true;
            this.personalArea.Click += new System.EventHandler(this.personalArea_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1261, 348);
            this.dataGridView1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Broadway", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search for:";
            // 
            // RealEstate
            // 
            this.RealEstate.BackColor = System.Drawing.Color.Salmon;
            this.RealEstate.Location = new System.Drawing.Point(143, 426);
            this.RealEstate.Name = "RealEstate";
            this.RealEstate.Size = new System.Drawing.Size(94, 23);
            this.RealEstate.TabIndex = 6;
            this.RealEstate.Text = "Real-Estate";
            this.RealEstate.UseVisualStyleBackColor = false;
            this.RealEstate.Click += new System.EventHandler(this.RealEstate_Click);
            // 
            // SecondHend
            // 
            this.SecondHend.Location = new System.Drawing.Point(261, 426);
            this.SecondHend.Name = "SecondHend";
            this.SecondHend.Size = new System.Drawing.Size(90, 23);
            this.SecondHend.TabIndex = 7;
            this.SecondHend.Text = "Second-Hand";
            this.SecondHend.UseVisualStyleBackColor = true;
            // 
            // Vehicle
            // 
            this.Vehicle.Location = new System.Drawing.Point(380, 426);
            this.Vehicle.Name = "Vehicle";
            this.Vehicle.Size = new System.Drawing.Size(89, 22);
            this.Vehicle.TabIndex = 8;
            this.Vehicle.Text = "Vehicle";
            this.Vehicle.UseVisualStyleBackColor = true;
            // 
            // Pet
            // 
            this.Pet.Location = new System.Drawing.Point(501, 426);
            this.Pet.Name = "Pet";
            this.Pet.Size = new System.Drawing.Size(90, 23);
            this.Pet.TabIndex = 9;
            this.Pet.Text = "Pet";
            this.Pet.UseVisualStyleBackColor = true;
            this.Pet.Click += new System.EventHandler(this.Pet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(903, 503);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 97);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Everything4rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1267, 669);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Pet);
            this.Controls.Add(this.Vehicle);
            this.Controls.Add(this.SecondHend);
            this.Controls.Add(this.RealEstate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.personalArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Everything4rent";
            this.Text = "Everything4rent";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button personalArea;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RealEstate;
        private System.Windows.Forms.Button SecondHend;
        private System.Windows.Forms.Button Vehicle;
        private System.Windows.Forms.Button Pet;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}