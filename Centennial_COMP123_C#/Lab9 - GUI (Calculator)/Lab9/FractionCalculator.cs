using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            Fraction first;
            Fraction second;
            Fraction result = new Fraction();

            try
            {
                if ((int.Parse(txtFirstDem.Text) == 0) || (int.Parse(txtSecondDem.Text) == 0))
                    throw new DivideByZeroException();
                first = new Fraction(int.Parse(txtFirstNum.Text), int.Parse(txtFirstDem.Text));
                second = new Fraction(int.Parse(txtSecondNum.Text), int.Parse(txtSecondDem.Text));

                if (rbtnAddition.Checked)
                    result = Fraction.Add(first, second);
                else
                if (rbtnSubtraction.Checked)
                    result = Fraction.Subtract(first, second);
                else
                if (rbtnMultiplication.Checked)
                    result = Fraction.Multiplication(first, second);
                else
                if (rbtnDivision.Checked)
                {
                    if (int.Parse(txtSecondNum.Text) == 0)
                        throw new DivideByZeroException();
                    result = Fraction.Division(first, second);
                }
                txtResultNum.Text = result.ToString().Split('[',',')[1];
                txtResultDem.Text = result.ToString().Split(',',' ',']')[2];
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                txtResultNum.Text = "NA";
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
                txtResultNum.Text = "DIV 0";
            }
        }

        private void txtResultDem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true; //discard the non-digit entries
            }
        }

        private void txtResultNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true; //discard the non-digit entries
            }
        }

        private void txtSecondDem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true; //discard the non-digit entries
            }
        }

        private void txtSecondNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true; //discard the non-digit entries
            }
        }

        private void txtFirstDem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true; //discard the non-digit entries
            }
        }

        private void txtFirstNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true; //discard the non-digit entries
            }
        }
    }
}
