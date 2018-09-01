﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalc
{
    public partial class SimpleCalc : Form
    {
        double value = 0;
        string opr = "";
        bool oprPressed = false;

        public SimpleCalc()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (oprPressed))
                result.Clear();

            Button b = (Button)sender;
            result.Text = result.Text + b.Text;

        }

        private void BtnClearEntry_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void Opr_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            opr = b.Text;
            value = double.Parse(result.Text);
            oprPressed = true;
        }

        private void BtnEqual(object sender, EventArgs e)
        {
            switch(opr)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            } // End switch
            oprPressed = true;
        }

        private void BtnClear(object sender, EventArgs e)
        {
            value = 0;
            result.Clear();
        }
    }
}

