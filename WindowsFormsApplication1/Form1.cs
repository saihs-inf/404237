﻿using System;
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
    }
}
