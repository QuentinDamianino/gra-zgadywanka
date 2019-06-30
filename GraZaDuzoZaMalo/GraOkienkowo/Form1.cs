using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraOkienkowo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int counter = 0;
        int randomNumber = 0;
        int time = 0;

        private int getRandomNumber(int min, int max)
        {
            if (min > max)
            {
                int temp = max;
                max = min;
                min = temp;
            }

            Random generator = new Random();
            return generator.Next(min, max + 1);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkIfWin(int myNumber)
        {
            counter++;
            label6.Text = counter.ToString();

            if (randomNumber == myNumber)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                button1.Enabled = true;
                textBox3.Enabled = false;
                button2.Enabled = false;
                label6.Text = "Wygrana";
                label10.Text = string.Format("Udało ci się odgadnąć w {0} próbach i zajeło ci to {1} sekund", counter, time);
                timer1.Enabled = false;
                pictureBox1.Visible = true;
            } else if (myNumber > randomNumber)
            {
                label6.Text = "Za dużo";
            } else if (myNumber < randomNumber)
            {
                label6.Text = "Za mało";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            label7.Text = time.ToString() + " s";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                randomNumber = getRandomNumber(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                button1.Enabled = false;
                textBox3.Enabled = true;
                button2.Enabled = true;
                counter = 0;
                time = 0;
                label6.Text = counter.ToString();
                label7.Text = time.ToString() + " s";
                timer1.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Błędne dane");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                checkIfWin(Convert.ToInt32(textBox3.Text));
            }
            catch
            {
                MessageBox.Show("Błąd ! niepoprawne liczby !");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
