﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void dichotomyButton_Click(object sender, EventArgs e)
        {
            dichotomyForm dichotomyForm = new dichotomyForm();
            dichotomyForm.Show();
        }

        private void GoldenRatioButton_Click(object sender, EventArgs e)
        {
            GoldenRatioForm goldenRatioForm = new GoldenRatioForm();
            goldenRatioForm.Show();
        }

        private void NewtonButton_Click(object sender, EventArgs e)
        {
            Newton newton = new Newton();
            newton.Show();
        }
    }
}
