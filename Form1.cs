using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factoral_Loop01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fac1, number;
            number = int.Parse(tb_1.Text);
            fac1 = 1;
            for (int x = 1; x <= number; x = x + 1)
                fac1 = fac1 * x;
            tb_sum.Text = fac1.ToString();

        }
    }
}
