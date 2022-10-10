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
    public partial class CurrentP : Form
    {
        public CurrentP()
        {
            InitializeComponent();
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
            Calculate c = new Calculate();
            c.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Show();
        }
    }
}
