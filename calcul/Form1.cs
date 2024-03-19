using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static double sum(double a, double b)
        {
            return a + b;
        }

        public static double razn(double a, double b)
        {
            return a - b;
        }

        public static double umnog(double a, double b)
        {
            return a * b;
        }

        public static double del(double a, double b)
        {
            return a / b;
        }

        public static double step(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public static double koren(double a, double b)
        {
            return Math.Pow(a, 1/b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1, number2;

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Введите корректные значения! (Поля не должны быть пустыми!)", "Ошибка!");
                return;
            }

            if (!double.TryParse(textBox1.Text, out number1) || !double.TryParse(textBox2.Text, out number2))
            {
                MessageBox.Show("Введите числовые значения!", "Ошибка");
                return;
            }

            textBox3.Text = Convert.ToString(sum(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double number1, number2;

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Введите корректные значения! (Поля не должны быть пустыми!)", "Ошибка!");
                return;
            }

            if (!double.TryParse(textBox1.Text, out number1) || !double.TryParse(textBox2.Text, out number2))
            {
                MessageBox.Show("Введите числовые значения!", "Ошибка");
                return;
            }

            textBox3.Text = Convert.ToString(razn(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double number1, number2;

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Введите корректные значения! (Поля не должны быть пустыми!)", "Ошибка!");
                return;
            }

            if (!double.TryParse(textBox1.Text, out number1) || !double.TryParse(textBox2.Text, out number2))
            {
                MessageBox.Show("Введите числовые значения!", "Ошибка");
                return;
            }

            textBox3.Text = Convert.ToString(umnog(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double number1, number2;

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Введите корректные значения! (Поля не должны быть пустыми!)", "Ошибка!");
                return;
            }

            if (!double.TryParse(textBox1.Text, out number1) || !double.TryParse(textBox2.Text, out number2))
            {
                MessageBox.Show("Введите числовые значения!", "Ошибка");
                return;
            }

            textBox3.Text = Convert.ToString(del(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double number1, number2;

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Введите корректные значения! (Поля не должны быть пустыми!)", "Ошибка!");
                return;
            }

            if (!double.TryParse(textBox1.Text, out number1) || !double.TryParse(textBox2.Text, out number2))
            {
                MessageBox.Show("Введите числовые значения!", "Ошибка");
                return;
            }

            textBox3.Text = Convert.ToString(step(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double number1, number2;

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Введите корректные значения! (Поля не должны быть пустыми!)", "Ошибка!");
                return;
            }

            if (!double.TryParse(textBox1.Text, out number1) || !double.TryParse(textBox2.Text, out number2))
            {
                MessageBox.Show("Введите числовые значения!", "Ошибка");
                return;
            }

            textBox3.Text = Convert.ToString(koren(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
