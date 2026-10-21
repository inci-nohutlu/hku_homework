using System;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnCheckPass_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtScore.Text.Trim(), out double score))
            {
                if (score < 0 || score > 100)
                {
                    MessageBox.Show("Lütfen 0 ile 100 arasında bir puan giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string status = score >= 50 ? "Pass (Geçti)" : "Fail (Kaldı)";
                lblResult.Text = $"Status: {status}";
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
        private void btnLetterGrade_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtScore.Text.Trim(), out double score))
            {
                if (score < 0 || score > 100)
                {
                    MessageBox.Show("Lütfen 0 ile 100 arasında bir puan giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string letter = "";
                if (score >= 90) letter = "A";
                else if (score >= 80) letter = "B";
                else if (score >= 70) letter = "C";
                else if (score >= 60) letter = "D";
                else letter = "F";

                lblResult.Text = $"Harf Notu: {letter}";
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void btnAvarage_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtScore.Text.Trim(), out double score))
            {
                if (score < 0 || score > 100)
                {
                    MessageBox.Show("Lütfen 0 ile 100 arasında bir puan giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double distance = 100 - score;
                lblResult.Text = $"100'e Olan Uzaklık: {distance}";
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
