using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace ITM
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {

            InitializeComponent();

            this.BackgroundImage = Properties.Resources.Apple_Health_study_July_2022_hero_jpg_og;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            DataTable bmiTable = new DataTable();
            bmiTable.Columns.Add("Êàòåãîðèÿ", typeof(string));
            bmiTable.Columns.Add("Ãðàíèöè", typeof(string));

            bmiTable.Rows.Add("Ïîäíîðìåíî", "Ïîä 18.9");
            bmiTable.Rows.Add("Íîðìà", "19 - 24.9");
            bmiTable.Rows.Add("Íàäíîðìà", "25.0 - 29.9");
            bmiTable.Rows.Add("Çàòëúñòÿâàíå", "30.0 - 34.9");
            bmiTable.Rows.Add("Òåæêî çàòëúñòÿâàíå", "Íàä 40");

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
                    case "Ïîäíîðìåíî":
                        color = Color.Blue;
                        break;
                    case "Íîðìà":
                        color = Color.Green;
                        break;
                    case "Íàäíîðìà":
                        color = Color.Yellow;
                        break;
                    case "Çàòëúñòÿâàíå":
                        color = Color.Orange;
                        break;
                    case "Òåæêî çàòëúñòÿâàíå":
                        color = Color.Red;
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
            if (!int.TryParse(txtBoxAge.Text, out age) || age <= 0)
            {
                MessageBox.Show("Ìîëÿ âúâåäåòå êîðåêòíà âúçðàñò - öÿëî ÷èñëî");
                return;
            }
            // Check if the input values are valid
            if (!double.TryParse(textBoxKG.Text, out weight) || !double.TryParse(textBoxHight.Text, out height))
            {
                MessageBox.Show("Ìîëÿ âúâåäåòå êîðåêòíè äàííè çà âèñî÷èíà è òåãëî.");
                return;
            }

            // Check if the input values are greater than 0
            if (weight <= 0 || height <= 0 || height > 210 || weight > 150 )
            {
                MessageBox.Show("Ìîëÿ âúâåäåòå ñòîéíîñòè ïî-âèñîêè îò 0.");
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
                txtBodyMass.Text = bodyMass.ToString("N1") + "êã";
                bmr = 10 * weight + 6.25 * height - 5 * age + 5;
                txtBMR.Text = bmr.ToString("N1")+ "kcal/äåí";
            }
            else if (radioButton2.Checked)
            {

                double bodyFat = (1.20 * bmi) +(0.23 * age) - 5.4;
                txtBodyFat.Text = bodyFat.ToString("N1") + "%";
                double bodyMass = weight * (1 - bodyFat / 100);
                txtBodyMass.Text = bodyMass.ToString("N1")+"êã";
                bmr = 10 * weight + 6.25 * height - 5 * age - 161;
                txtBMR.Text = bmr.ToString("N1") + "kcal/äåí";
            }

         // Change the color of the txtResult text box based on the BMI value
            if (bmi >= 9 && bmi <= 18)
            {
                    textBoxResult.BackColor = Color.Blue;
            }
            else if (bmi > 18 && bmi <= 23)
            {
                    textBoxResult.BackColor = Color.Green;
            }
            else if (bmi > 23 && bmi <= 29)
                {
                    textBoxResult.BackColor = Color.Yellow;
                }
            else if (bmi > 29 && bmi <= 38)
            {
                    textBoxResult.BackColor = Color.Orange;
            }
            else if (bmi > 38 && bmi <= 65)
            {
                 textBoxResult.BackColor = Color.Red;
            }
            else
            {
                   textBoxResult.BackColor = Color.Purple;
            }

        }

        private void textBoxResult_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Visible = true;   
        }
    }
}
