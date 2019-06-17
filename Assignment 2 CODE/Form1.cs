using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_CODE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double R1, R2, R3, R4, R5, TotalSeriesResistance, TotalParallelResistance;
            try
            {
                R1 = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                R1 = 0;
            }
            try
            {
                R2 = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                R2 = 0;
            }
            try
            {
                R3 = Convert.ToDouble(textBox3.Text);
            }
            catch
            {
                R3 = 0;
            }
            try
            {
                R4 = Convert.ToDouble(textBox4.Text);
            }
            catch
            {
                R4 = 0;
            }
            try
            {
                R5 = Convert.ToDouble(textBox5.Text);
            }
            catch
            {
                R5 = 0;
            }
            TotalSeriesResistance = R1 + R2 + R3 + R4 + R5;
            label6.Text = "Total Series Resistance = " + TotalSeriesResistance;

            if (R1 == 0)
            {
                R1 = Double.PositiveInfinity;
            }
            if (R2 == 0)
            {
                R2 = Double.PositiveInfinity;
            }
            if (R3 == 0)
            {
                R3 = Double.PositiveInfinity;
            }
            if (R4 == 0)
            {
                R4 = Double.PositiveInfinity;
            }
            if (R5 == 0)
            {
                R5 = Double.PositiveInfinity;
            }
            TotalParallelResistance = 1 / (1 / R1 + 1 / R2 + 1 / R3 + 1 / R4 + 1 / R5);
            label7.Text = "Total Parallel Resistance = " + TotalParallelResistance;
        }

    }
}