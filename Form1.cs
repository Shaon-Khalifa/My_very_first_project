using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void SUM_Click(object sender, EventArgs e)
        {
            Double Fnumber = Convert.ToDouble(FIRST.Text);
            Double snumber = Convert.ToDouble(SECOND.Text);
            double result = Fnumber + snumber;
            RESULTS.Text = result.ToString();
        }

        private void MINUS_Click(object sender, EventArgs e)
        {
            Double Fnumber = Convert.ToDouble(FIRST.Text);
            Double snumber = Convert.ToDouble(SECOND.Text);
            double result = Fnumber - snumber;
            RESULTS.Text = result.ToString();
        }

        private void DIVIDE_Click(object sender, EventArgs e)
        {
            Double Fnumber = Convert.ToDouble(FIRST.Text);
            Double snumber = Convert.ToDouble(SECOND.Text);
            double result = Fnumber / snumber;
            RESULTS.Text = result.ToString();
        }

        private void MULIPLE_Click(object sender, EventArgs e)
        {
            Double Fnumber = Convert.ToDouble(FIRST.Text);
            Double snumber = Convert.ToDouble(SECOND.Text);
            double result = Fnumber * snumber;
            RESULTS.Text = result.ToString();
        }

        private void C_Click(object sender, EventArgs e)
        {
            FIRST.Clear();
            SECOND.Clear();
            RESULTS.Clear();
            FIRST.Focus();
        }
    }
}
