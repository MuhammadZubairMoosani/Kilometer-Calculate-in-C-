using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            meterBox.Text = (double.Parse(input.Text) * 1000).ToString();
            feetBox.Text = (double.Parse(input.Text) * 3280.84).ToString();
            InchesBox.Text = (double.Parse(input.Text) * 39370.1).ToString();
            centBox.Text = (double.Parse(input.Text) * 100000).ToString();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            meterBox.Text = "";
            feetBox.Text = "";
            InchesBox.Text = "";
            centBox.Text = "";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
