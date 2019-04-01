using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea280319
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            



        }

        private void button1_Click(object sender, EventArgs e)
        {




            double res = 0,  num1= 0, num2 = 0;
            num1 = Convert.ToDouble(textNum1.Text);
            num2 = Convert.ToDouble(textNum2.Text);

            if (checkSuma.Checked == true)
            { 

                    res =  num1 + num2;


            }

            if (checkResta.Checked == true)
            {

                res = num1 - num2;


            }

            if (checkMultiplicacion.Checked == true)
            {

                res = num1 * num2;


            }


            if (checkDivision.Checked == true)
            {

                res = num1 / num2;


            }

            labResultado.Text = res.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
