using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var date1 = dateTimePicker1.Value;
            var date2 = dateTimePicker2.Value;
            //int number = 0;
      
            switch(comboBox1.SelectedIndex)
            {
                case 0:textBox1.Text =  Calculator.getTomorrow(date1);
                    break;
                case 1:textBox1.Text = Calculator.getYesterday(date1);
                    break;
                case 2: textBox1.Text = Calculator.getDayAfetrTomorrow(date1);
                    break;
                case 3:
                    textBox1.Text = Calculator.getDayBeforeYesterday(date1);
                    break;
                case 4:

                    if (int.TryParse(textBox2.Text,out int number))
                    {
                        textBox1.Text = Calculator.addDays(date1, number);
                    }
                    else
                    {
                        MessageBox.Show("Invalid value passed");
                    }
                    break;
                case 5:
                    
                    if (int.TryParse(textBox2.Text, out int number1))
                    {
                        textBox1.Text = Calculator.addMonths(date1, number1);
                    }
                    else
                    {
                        MessageBox.Show("Invalid value passed");
                    }
                    break;

                case 6:
                    if (int.TryParse(textBox2.Text, out int number2))
                    {
                        textBox1.Text = Calculator.addYears(date1, number2);
                    }
                    else
                    {
                        MessageBox.Show("Invalid value passed");
                    }
                    break;

                case 7:
                    if (int.TryParse(textBox2.Text, out int number3))
                    {
                        textBox1.Text = Calculator.subDays(date1, number3);
                    }
                    else
                    {
                        MessageBox.Show("Invalid value passed");
                    }
                    break;

                case 8:
                    if (int.TryParse(textBox2.Text, out int number4))
                    {
                        textBox1.Text = Calculator.subMonths(date1, number4);
                    }
                    else
                    {
                        MessageBox.Show("Invalid value passed");
                    }
                    break;

                case 9:
                    if (int.TryParse(textBox2.Text, out int number5))
                    {
                        textBox1.Text = Calculator.subYears(date1, number5);
                    }
                    else
                    {
                        MessageBox.Show("Invalid value passed");
                    }
                    break;
                case 10:
                    textBox1.Text = Calculator.calculateDifference(date1, date2);
                    break;

                case 11:
                    textBox1.Text = date1.DayOfWeek.ToString();
                    break;
                case 12:
                    textBox1.Text = Calculator.dayOfYear(date1);
                    break;


            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 12:
                case 11:
                case 0:
                case 1:
                case 2:
                case 3: dateTimePicker2.Enabled = false;
                        textBox2.Enabled = false;
                        break;

                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9: dateTimePicker2.Enabled = false;
                        textBox2.Enabled = true;
                    break;
                case 10: dateTimePicker2.Enabled = true;
                    textBox2.Enabled = false;
                    break;
                      
            }
        }
    }

    
}
