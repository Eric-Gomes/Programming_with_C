using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void colourCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (colourCheckBox.Checked == true)
            {
                colourCheckBox.ForeColor = Color.Red;
            }
            else if (colourCheckBox.Checked == false)
            {
                colourCheckBox.ForeColor = Color.Black;
            }


        }
    }

}