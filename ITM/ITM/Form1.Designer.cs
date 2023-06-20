namespace ITM
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            this.kg = new System.Windows.Forms.Label();
            this.Hight = new System.Windows.Forms.Label();
            this.textBoxKG = new System.Windows.Forms.TextBox();
            this.textBoxHight = new System.Windows.Forms.TextBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtBodyFat = new System.Windows.Forms.TextBox();
            this.lblITM = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBodyMass = new System.Windows.Forms.TextBox();
            this.txtBMR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // kg
            // 
            this.kg.AutoSize = true;
            this.kg.BackColor = System.Drawing.Color.Transparent;
            this.kg.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kg.Location = new System.Drawing.Point(46, 34);
            this.kg.Name = "kg";
            this.kg.Size = new System.Drawing.Size(173, 30);
            this.kg.TabIndex = 3;
            this.kg.Text = "Вашето тегло";
            // 
            // Hight
            // 
            this.Hight.AutoSize = true;
            this.Hight.BackColor = System.Drawing.Color.Transparent;
            this.Hight.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Hight.Location = new System.Drawing.Point(19, 143);
            this.Hight.Name = "Hight";
            this.Hight.Size = new System.Drawing.Size(216, 30);
            this.Hight.TabIndex = 4;
            this.Hight.Text = "Вашата височина";
            // 
            // textBoxKG
            // 
            this.textBoxKG.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxKG.Location = new System.Drawing.Point(19, 67);
            this.textBoxKG.Multiline = true;
            this.textBoxKG.Name = "textBoxKG";
            this.textBoxKG.Size = new System.Drawing.Size(220, 59);
            this.textBoxKG.TabIndex = 5;
            this.textBoxKG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHight
            // 
            this.textBoxHight.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxHight.Location = new System.Drawing.Point(19, 176);
            this.textBoxHight.Multiline = true;
            this.textBoxHight.Name = "textBoxHight";
            this.textBoxHight.Size = new System.Drawing.Size(220, 58);
            this.textBoxHight.TabIndex = 6;
            this.textBoxHight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonResult
            // 
            this.buttonResult.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonResult.Location = new System.Drawing.Point(416, 215);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(149, 105);
            this.buttonResult.TabIndex = 7;
            this.buttonResult.Text = "Резултат";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxResult.Location = new System.Drawing.Point(379, 387);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(220, 56);
            this.textBoxResult.TabIndex = 9;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxResult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxResult_MouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(670, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(321, 112);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ITM.Properties.Resources.BMI_index_01;
            this.pictureBox1.Location = new System.Drawing.Point(670, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(386, 129);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(100, 44);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Мъж";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(492, 129);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(107, 44);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Жена";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(448, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 45);
            this.label1.TabIndex = 18;
            this.label1.Text = "Пол";
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxAge.Location = new System.Drawing.Point(19, 292);
            this.txtBoxAge.Multiline = true;
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(220, 58);
            this.txtBoxAge.TabIndex = 20;
            this.txtBoxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAge.Location = new System.Drawing.Point(19, 259);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(196, 30);
            this.lblAge.TabIndex = 19;
            this.lblAge.Text = "Вашата възраст";
            // 
            // txtBodyFat
            // 
            this.txtBodyFat.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBodyFat.Location = new System.Drawing.Point(379, 469);
            this.txtBodyFat.Multiline = true;
            this.txtBodyFat.Name = "txtBodyFat";
            this.txtBodyFat.ReadOnly = true;
            this.txtBodyFat.Size = new System.Drawing.Size(220, 56);
            this.txtBodyFat.TabIndex = 21;
            this.txtBodyFat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblITM
            // 
            this.lblITM.AutoSize = true;
            this.lblITM.BackColor = System.Drawing.Color.White;
            this.lblITM.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblITM.Location = new System.Drawing.Point(19, 401);
            this.lblITM.Name = "lblITM";
            this.lblITM.Size = new System.Drawing.Size(351, 30);
            this.lblITM.TabIndex = 22;
            this.lblITM.Text = "Вашият индекс телесна маса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 568);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 30);
            this.label2.TabIndex = 23;
            this.label2.Text = "Чиста мускулна маса";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ITM.Properties.Resources.bodyFat;
            this.pictureBox2.Location = new System.Drawing.Point(670, 426);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 276);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 30);
            this.label3.TabIndex = 26;
            this.label3.Text = "Процент подкожни мазнини";
            // 
            // txtBodyMass
            // 
            this.txtBodyMass.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBodyMass.Location = new System.Drawing.Point(379, 554);
            this.txtBodyMass.Multiline = true;
            this.txtBodyMass.Name = "txtBodyMass";
            this.txtBodyMass.ReadOnly = true;
            this.txtBodyMass.Size = new System.Drawing.Size(220, 56);
            this.txtBodyMass.TabIndex = 25;
            this.txtBodyMass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBMR
            // 
            this.txtBMR.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBMR.Location = new System.Drawing.Point(379, 635);
            this.txtBMR.Multiline = true;
            this.txtBMR.Name = "txtBMR";
            this.txtBMR.ReadOnly = true;
            this.txtBMR.Size = new System.Drawing.Size(220, 56);
            this.txtBMR.TabIndex = 28;
            this.txtBMR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 649);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 30);
            this.label4.TabIndex = 27;
            this.label4.Text = "Базов метаболизъм";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1011, 719);
            this.Controls.Add(this.txtBMR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBodyMass);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblITM);
            this.Controls.Add(this.txtBodyFat);
            this.Controls.Add(this.txtBoxAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.textBoxHight);
            this.Controls.Add(this.textBoxKG);
            this.Controls.Add(this.Hight);
            this.Controls.Add(this.kg);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form";
            this.Text = "Здравословен Калкулатор";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label kg;
        private Label Hight;
        private TextBox textBoxKG;
        private TextBox textBoxHight;
        private Button buttonResult;
        private TextBox textBoxResult;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label1;
        private TextBox txtBoxAge;
        private Label lblAge;
        private TextBox txtBodyFat;
        private Label lblITM;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private TextBox txtBodyMass;
        private TextBox txtBMR;
        private Label label4;
    }

}
    
     