using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_fix
{
    public partial class Calculate : Form
    {
        int loanTerm;
        double loanAmt;
        double intRate;
        double monthlyPayments;
        double n;

        public Calculate()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loanAmt = Convert.ToDouble(textBox1.Text);
            if (loanAmt < 0 || loanAmt > 100000)
            {
                textBox1.Text = "amount must be between 0 and 100,000";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            loanTerm = Convert.ToInt32(textBox2.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "months")
            {
                n = loanTerm;
                if (loanTerm < 0 || loanTerm > 1200)
                {
                    textBox2.Text = "loan term must be between 0 and 1200";
                }
            }
            else if (listBox1.Text == "years")
            {
                n = loanTerm * 12;
                if (loanTerm < 0 || loanTerm > 100)
                {
                    textBox2.Text = "loan term must be between 0 and 100";
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            intRate = Convert.ToDouble(textBox3.Text);
            intRate = intRate / 100;
            if (intRate < 0 || intRate > 100)
            {
                textBox3.Text = "interest rate must be between 0% and 100%";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double i = intRate / 12;
            double x = 1 + i;
            monthlyPayments = loanAmt * (i * (Math.Pow(x, n)) / (Math.Pow(x, n) - 1));
            textBox4.Text = Convert.ToString(String.Format("{0:$.##}", monthlyPayments));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage h = new HomePage();
            h.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            CurrentP cp = new CurrentP();
            cp.Show();
        }
    }
}
