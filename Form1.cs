using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class FrmHesapMakinesi : Form
    {
        bool optDurum = false;
        double sonuc = 0;
        string operators;
        public FrmHesapMakinesi()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
        }

        private void RakamOlayi(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0" || optDurum)
            {
                txtSonuc.Clear();
            }
            optDurum = false;
            Button button = (Button)sender;
            txtSonuc.Text += button.Text;
        }

        private void Operatorler(object sender, EventArgs e)
        {
            optDurum = true;
            Button button = (Button)sender;
            string yeniOperator = button.Text;
            lblSonuc.Text = lblSonuc.Text + " " +txtSonuc.Text+ " " +yeniOperator;
            switch (operators)
            {
                case "+":
                    txtSonuc.Text = (sonuc + Double.Parse(txtSonuc.Text)).ToString();
                    break;

                case "-":
                    txtSonuc.Text = (sonuc - Double.Parse(txtSonuc.Text)).ToString();
                    break;

                case "*":
                    txtSonuc.Text = (sonuc * Double.Parse(txtSonuc.Text)).ToString();
                    break;

                case "/":
                    txtSonuc.Text = (sonuc / Double.Parse(txtSonuc.Text)).ToString();
                    break;
            }
            sonuc = Double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            operators = yeniOperator;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
            lblSonuc.Text = "0";
            operators = "";
            sonuc = 0;
            optDurum = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "";
            optDurum = true;
            switch (operators)
            {
                case "+":
                    txtSonuc.Text = (sonuc + Double.Parse(txtSonuc.Text)).ToString();
                    break;

                case "-":
                    txtSonuc.Text = (sonuc - Double.Parse(txtSonuc.Text)).ToString();
                    break;

                case "*":
                    txtSonuc.Text = (sonuc * Double.Parse(txtSonuc.Text)).ToString();
                    break;

                case "/":
                    txtSonuc.Text = (sonuc / Double.Parse(txtSonuc.Text)).ToString();
                    break;
            }
            sonuc = Double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            operators = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
            if (txtSonuc.Text=="0")
            {
                txtSonuc.Text = "0";
            }
            else if (optDurum)
            {
                txtSonuc.Text = "0";
            }
            if (!txtSonuc.Text.Contains(","))
            {
                txtSonuc.Text += ",";
            }
            optDurum = false;
        }
    }
}
