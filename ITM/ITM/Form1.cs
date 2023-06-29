using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace ITM
{
    public partial class Form : System.Windows.Forms.Form
    {
        private TextBox[] textboxes;
        private int currentIndex;
        public Form()
        {

            InitializeComponent();

            this.BackgroundImage = Properties.Resources.Apple_Health_study_July_2022_hero_jpg_og;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //Key next textbox
            textboxes = new TextBox[] { textBoxKG, textBoxHight, txtBoxAge };
            foreach (TextBox textbox in textboxes)
            {
                textbox.KeyDown += textBox_KeyDown;
            }

            // Настройте първоначалния индекс на текущото поле
            currentIndex = 0;

            // Задайте фокуса на първото текстово поле
            textboxes[currentIndex].Focus();
            /* textBoxKG.KeyDown += textBox_KeyDown;
             textBoxHight.KeyDown += textBox_KeyDown;
             txtBoxAge.KeyDown+= textBox_KeyDown;
             this.ActiveControl = textBoxKG;*/
            //Create BMI table
            DataTable bmiTable = new DataTable();
            bmiTable.Columns.Add("Категория", typeof(string));
            bmiTable.Columns.Add("Граници", typeof(string));

            bmiTable.Rows.Add("Поднормено", "Под 18.5");
            bmiTable.Rows.Add("Норма", "19 - 24.9");
            bmiTable.Rows.Add("Наднорма", "25.0 - 29.9");
            bmiTable.Rows.Add("Затлъстяване I степен", "30.0 - 34.9");
            bmiTable.Rows.Add("Затлъстяване II степен", "35.0 - 39.9");
            bmiTable.Rows.Add("Затлъстяване III степен", "Над 40");

            dataGridView1.DataSource = bmiTable;
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Set the WindowState to Maximized
            this.WindowState = FormWindowState.Maximized;

            // Set the Anchor property of each l

            textBoxHight.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            textBoxKG.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            textBoxResult.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            buttonResult.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            Hight.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            kg.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right /*| AnchorStyles.Bottom*/;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1) // Range column
            {
                string category = (string)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                Color color;

                switch (category)
                {
                    case "Поднормено":
                        color = Color.Blue;
                        break;
                    case "Норма":
                        color = Color.Green;
                        break;
                    case "Наднорма":
                        color = Color.Yellow;
                        break;
                    case "Затлъстяване I степен":
                        color = Color.Orange;
                        break;
                    case "Затлъстяване II степен":
                        color = Color.Red;
                        break;
                    case "Затлъстяване III степен":
                        color = Color.Purple;
                        break;
                    default:
                        color = Color.White;
                        break;
                }

                e.CellStyle.BackColor = color;
            }
        }


        private void buttonResult_Click(object sender, EventArgs e)
        {
            double weight, height, bmi,bmr;
          
            textBoxResult.ReadOnly = true;
            int age;
            
            // Check if the input values are valid
            if (!double.TryParse(textBoxKG.Text, out weight) || !double.TryParse(textBoxHight.Text, out height))
            {
                MessageBox.Show("Моля въведете коректни данни за височина, тегло и възраст!");
                return;
            }
            if (!int.TryParse(txtBoxAge.Text, out age) || age <= 0)
            {
                MessageBox.Show("Моля въведете коректна възраст - цяло число!");
                return;
            }
            if (weight < 30 || weight > 150 || height < 100 || height > 230)
            {
                MessageBox.Show("Моля въведете коректни стойности за тегло и височина!");
                return;
            }
            // Check if the input values are greater than 0
            if (weight <= 0 || height <= 0)
            {
                MessageBox.Show("Моля въведете стойности по-високи от 0.");
                return;
            }
            weight = double.Parse(textBoxKG.Text);
            height = double.Parse(textBoxHight.Text);
            bmi = weight / Math.Pow(height / 100, 2);
            textBoxResult.Text = bmi.ToString("N1");
            TextBox txtBodyFat = this.txtBodyFat;
            

            txtBodyFat.ReadOnly = true;
         
            if (radioButton1.Checked)
            {
                double bodyFat = (1.20 * bmi) + (0.23 * age) - 16.2;
                txtBodyFat.Text = bodyFat.ToString("N1") + "%";
                double bodyMass = weight * (1-bodyFat/100);
                txtBodyMass.Text = bodyMass.ToString("N1") + "кг";
                bmr = 10 * weight + 6.25 * height - 5 * age + 5;
                txtBMR.Text = bmr.ToString("N1")+ "kcal/ден";
            }
            else if (radioButton2.Checked)
            {

                double bodyFat = (1.20 * bmi) +(0.23 * age) - 5.4;
                txtBodyFat.Text = bodyFat.ToString("N1") + "%";
                double bodyMass = weight * (1 - bodyFat / 100);
                txtBodyMass.Text = bodyMass.ToString("N1")+"кг";
                bmr = 10 * weight + 6.25 * height - 5 * age - 161;
                txtBMR.Text = bmr.ToString("N1") + "kcal/ден";
            }

         // Change the color of the txtResult text box based on the BMI value
            if (bmi >= 9 && bmi <= 18.5)
            {
                    textBoxResult.BackColor = Color.Blue;
            }
            else if (bmi >= 19 && bmi <= 24.9)
            {
                    textBoxResult.BackColor = Color.Green;
            }
            else if (bmi >= 25 && bmi <= 29.9)
                {
                    textBoxResult.BackColor = Color.Yellow;
                }
            else if (bmi >= 30 && bmi <= 34.9)
            {
                    textBoxResult.BackColor = Color.Orange;
            }
            else if (bmi >= 35 && bmi <= 39.9)
            {
                 textBoxResult.BackColor = Color.Red;
            }
            else
            {
                   textBoxResult.BackColor = Color.Purple;
            }

        }
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                // Преминете към следващото текстово поле
                currentIndex++;

                // Ако сме достигнали последното поле, нулирайте индекса, за да започнете отначало
                if (currentIndex >= textboxes.Length)
                {
                    currentIndex = 0;
                  
                }
                textboxes[currentIndex].Focus();
            }
        }
        private void textBoxResult_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Visible = true;   
        }

        private void txtBodyMass_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox2.Visible = true;
        }
    }
}
