﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CsP.Little_Dictinary_Builder
{
    public partial class TryForm : Form
    {
        public TryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Program.d.translateWord(textBox1.Text);
        }
    }
}
