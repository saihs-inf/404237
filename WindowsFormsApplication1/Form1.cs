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
        int a, b;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "hello wong";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1 .Text ;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello worng");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("good");
        }

        private void button4_Click(object sender, EventArgs e)
        {            
            textBox2.Text = a.ToString ();
            textBox3.Text = b.ToString ();
            textBox4.Text = a.ToString () + b.ToString ();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = a.ToString();
            textBox3.Text = b.ToString();
           
        }
    }
}
