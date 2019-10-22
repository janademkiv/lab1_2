using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k, n;

            double h, x, y;

            //x = 0.68;
            //y = -0.848;
        

            //получение значений
            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            
            //формула расчета
            h = (Math.Pow((Math.Sin(x)), 3) + Math.Exp(-Math.Sin(y))) / 0.6 * Math.Pow(x, 2) * Math.Pow(y, 2);

            //ответ k и n приводим double к int
            k = Convert.ToInt32(h);
        
            n = Convert.ToInt32(Math.Truncate(h));
            
            //Значение h
            textBox3.Text = Convert.ToString(h);
            //Значение k
            textBox4.Text = Convert.ToString(k);
            //Значение n
            textBox5.Text = Convert.ToString(n);
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
