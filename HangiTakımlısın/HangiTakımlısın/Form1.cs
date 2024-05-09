using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangiTakımlısın
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                Form2 fb = new Form2();
                fb.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
          if(radioButton3.Checked==true)
            {
                Form3 gs = new Form3();
                gs.Show();
                this.Hide();
            }
            
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if(radioButton2.Checked=true) {
                Form4 bjk = new Form4();
                bjk.Show();
                this.Hide();
            }
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton4.Checked = true)
            {
                Form5 ts = new Form5();
                ts.Show();
                this.Hide();
                
            }
        }
    }
}
