﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += delegate (object sender, EventArgs e)
            {
                button1.BackColor = Color.Red;
            };
            button1.Click += CustomAlert;
            button1.Click += Test;
            button1.Click -= CustomAlert;
        }

        public void CustomAlert(object sender, EventArgs e)
        {
            MessageBox.Show("Ala");
        }

        public void Test(object sender, EventArgs e)
        {
            button1.BackColor = Color.Aqua;
        }
    }
}
