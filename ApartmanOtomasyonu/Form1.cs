﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Gelirler_Click(object sender, EventArgs e)
        {
            new Gelirler().Show();
        }

        private void btn_Giderler_Click(object sender, EventArgs e)
        {
            new Giderler().Show();
        }
    }
}
