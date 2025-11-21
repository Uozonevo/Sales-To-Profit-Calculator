using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECE_2310_HW3_part3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sales1, sales, profit;
            double profitRatio;



            sales = double.Parse(textBox1.Text);
            if (sales <= 1000) 
            {
                sales1 = sales;
                textBox2.Text = sales1.ToString();
                profitRatio = 3;
                textBox3.Text = profitRatio.ToString();
                profit = sales * profitRatio * 0.001;
                textBox4.Text = profit.ToString();

            }
            else if(sales >1000 && sales <= 5000)
            {
                sales1 = sales;
                textBox2.Text = sales1.ToString();
                profitRatio = 3.5;
                textBox3.Text = profitRatio.ToString();
                profit = sales * profitRatio * 0.001;
                textBox4.Text = profit.ToString();
            }
            else if(sales >5000 && sales <= 10000)
            {
                sales1 = sales;
                textBox2.Text = sales1.ToString();
                profitRatio = 4;
                textBox3.Text = profitRatio.ToString();
                profit = sales * profitRatio * 0.001;
                textBox4.Text = profit.ToString();
            }
            else if(sales >10000)
            {
                sales1 = sales;
                textBox2.Text = sales1.ToString();
                profitRatio = 4.5;
                textBox3.Text = profitRatio.ToString();
                profit = sales * profitRatio * 0.001;
                textBox4.Text = profit.ToString();
            }


        }
    }
}
