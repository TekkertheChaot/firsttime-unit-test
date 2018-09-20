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
        public Form1()
        {
            InitializeComponent();
            checkButtonActivation();
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            Bruch b = new Bruch(double.Parse(box_zaehler.Text), double.Parse(box_nenner.Text));
            b.shorten();
            box_nenner.Text = b.nenner.ToString();
            box_zaehler.Text = b.zaehler.ToString();
            box_ergebnis.Text = b.proceed().ToString();
        }

        private void box_zaehler_TextChanged(object sender, EventArgs e)
        {
            checkButtonActivation();
        }

        private void box_nenner_TextChanged(object sender, EventArgs e)
        {
            checkButtonActivation();
        }
        private void checkButtonActivation()
        {
            if (box_nenner.Text != "" && box_zaehler.Text != "")
            {
                btn_proceed.Enabled = true;
            }
            else btn_proceed.Enabled = false;
        }
    }
}
