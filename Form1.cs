using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Laba12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ACipher cipher = new ACipher();
            textBox2.Text = cipher.Encode(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ACipher cipher = new ACipher();
            textBox2.Text = cipher.Decode(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BCipher cipher = new BCipher();
            textBox3.Text = cipher.Encode(textBox4.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BCipher cipher = new BCipher();
            textBox3.Text = cipher.Decode(textBox4.Text);
        }
    }
}
