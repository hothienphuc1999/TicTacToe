using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_DACK
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int col = int.Parse(textBox1.Text);

            // board size
            if (col < 3)
                Dashboard.colAndRow = 3;
            else if (col > 5)
                Dashboard.colAndRow = 5;
            else
                Dashboard.colAndRow = col;

            // level
            if (radioButton1.Checked == true)
            {
                Dashboard.level = 1;
            }
            if (radioButton3.Checked == true)
            {
                Dashboard.level = 0;
            }

            // mode
            if (mode1RadioButton.Checked == true)
            {
                Dashboard.mode = 0;
            }
            if (mode2RadioButton.Checked == true)
            {
                Dashboard.mode = 1;
            }

            this.Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
        }
    }
}
