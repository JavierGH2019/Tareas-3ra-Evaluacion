using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        int a = 0;
        public Form1()
        {
            InitializeComponent();
            progressBar1.Maximum = 10;
            progressBar1.Minimum = 0;
            progressBar1.Step = 2;

            

            
            


             

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 20;i++ )
            {
                progressBar1.PerformStep();
            }
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer4.Enabled = false;
            button4.BackColor = Color.White;
            button2.BackColor = Color.Red;
            timer2.Enabled = true;
            progressBar1.PerformStep();

             
        }

        

        private void timer2_Tick(object sender, EventArgs e)
        {

            progressBar1.PerformStep();
            timer1.Enabled = false;
            button2.BackColor=Color.White;
            button3.BackColor = Color.Yellow;
            timer3.Enabled = true;

            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            button3.BackColor = Color.White;
            timer2.Enabled = false;
            
            button4.BackColor = Color.LightGreen;
            timer4.Enabled = true;
            

        }

       


        private void timer4_Tick_1(object sender, EventArgs e)
        {
             
            timer3.Enabled = false;
            timer1.Enabled = true;
            progressBar1.PerformStep();
            
            if (progressBar1.Value==10)
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
                timer1.Stop();
                timer4.Enabled = false;

            }
            
        }

        

         
    }
}
