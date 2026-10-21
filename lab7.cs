using System;
using System.Linq;
using System.Windows.Forms;

namespace lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnSumDigits_Click(object sender, EventArgs e)
        {
            if (long.TryParse(txtNumber.Text.Trim(), out long number))
            {
                
                number = Math.Abs(number);

                long sum = 0;
                long temp = number;

                while (temp > 0)
                {
                    sum += temp % 10; 
                    temp /= 10;       
                }

                
                if (number == 0) sum = 0;

                lblResult.Text = $"Sum of Digits: {sum}";
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir tam sayı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
        private void btnCountEven_Click(object sender, EventArgs e)
        {
            if (long.TryParse(txtNumber.Text.Trim(), out long number))
            {
                number = Math.Abs(number);

                int evenCount = 0;

                
                if (number == 0)
                {
                    evenCount = 1;
                }
                else
                {
                    long temp = number;
                    while (temp > 0)
                    {
                        long digit = temp % 10;
                        if (digit % 2 == 0)
                        {
                            evenCount++;
                        }
                        temp /= 10;
                    }
                }

                lblResult.Text = $"Count of Even Digits: {evenCount}";
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir tam sayı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
