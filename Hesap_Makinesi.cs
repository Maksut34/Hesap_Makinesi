using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Hesap_Makinesi : Form
    {
        private string _işlem;
        bool _temizle;
        private int _sayı;
        private int _sayı2;
        private int _sonuç;
        public Hesap_Makinesi()
        {
            InitializeComponent();
        }

        
        private void btn_1_Click(object sender, EventArgs e)
        {
            if (_temizle)
            {
                txt_ekran.Text="";
                _temizle= false;
            }
            if (txt_ekran.Text == "0") txt_ekran.Clear();
            txt_ekran.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (_temizle)
            {
                txt_ekran.Text = "";
                _temizle = false;
            }
            if (txt_ekran.Text == "0") txt_ekran.Clear();
            txt_ekran.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (_temizle)
            {
                txt_ekran.Text = "";
                _temizle = false;
            }
            if (txt_ekran.Text == "0") txt_ekran.Clear();
            txt_ekran.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (_temizle)
            {
                txt_ekran.Text = "";
                _temizle = false;
            }
            if (txt_ekran.Text == "0") txt_ekran.Clear();
            txt_ekran.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (_temizle)
            {
                txt_ekran.Text = "";
                _temizle = false;
            }
            if (txt_ekran.Text == "0") txt_ekran.Clear();
            txt_ekran.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (_temizle)
            {
                txt_ekran.Text = "";
                _temizle = false;
            }
            if (txt_ekran.Text == "0") txt_ekran.Clear();
            txt_ekran.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (_temizle)
            {
                txt_ekran.Text = "";
                _temizle = false;
            }
            if (txt_ekran.Text == "0") txt_ekran.Clear();
            txt_ekran.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (_temizle)
            {
                txt_ekran.Text = "";
                _temizle = false;
            }
            if (txt_ekran.Text == "0") txt_ekran.Clear();
            txt_ekran.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (_temizle)
            {
                txt_ekran.Text = "";
                _temizle = false;
            }
            if (txt_ekran.Text == "0") txt_ekran.Clear();
            txt_ekran.Text += "9";
        }

        private void btn_00_Click(object sender, EventArgs e)
        {
            if (_temizle)
            {
                txt_ekran.Text = "";
                _temizle = false;
            }
            if (txt_ekran.Text == "0") txt_ekran.Clear();
            txt_ekran.Text += "00";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (_temizle)
            {
                txt_ekran.Text = "";
                _temizle = false;
            }
            if (txt_ekran.Text == "0") txt_ekran.Clear();
            txt_ekran.Text += "0";
        }

        private void btn_nokta_Click(object sender, EventArgs e)
        {
            if (_temizle)
            {
                txt_ekran.Text = "";
                _temizle = false;
            }
            if (txt_ekran.Text=="0")txt_ekran.Clear();
            txt_ekran.Text += ".";
        }

        private void btn_OFF_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            txt_ekran.Clear();
        }

        private void btn_tek_tek_C_Click(object sender, EventArgs e)
        {
            txt_ekran.Text=txt_ekran.Text.Substring(0,txt_ekran.Text.Length-1);
        }

        private void btn_artı_Click(object sender, EventArgs e)
        {
            _işlem = "+";
            _temizle= true;
            _sayı = Convert.ToInt32(txt_ekran.Text);
        }

        private void btn_eksi_Click(object sender, EventArgs e)
        {
            _işlem = "_";
            _temizle = true;
            _sayı = Convert.ToInt32(txt_ekran.Text);
        }

        private void btn_bölme_Click(object sender, EventArgs e)
        {
            _işlem = "/";
            _temizle = true;
            _sayı = Convert.ToInt32(txt_ekran.Text);
        }

        private void btn_çarpma_Click(object sender, EventArgs e)
        {
            _işlem = "x";
            _temizle = true;
            _sayı = Convert.ToInt32(txt_ekran.Text);
        }

        private void btn_eşittir_Click(object sender, EventArgs e)
        {
            _sayı2=Convert.ToInt32(txt_ekran.Text);
            if (_işlem == "+")
            {
                _sonuç = _sayı + _sayı2;
                txt_ekran.Text = _sonuç.ToString();
            }
            else if (_işlem == "x")
            {
                _sonuç = _sayı * _sayı2;
                txt_ekran.Text = _sonuç.ToString();
            }
            else if (_işlem == "/")
            {
                _sonuç = _sayı / _sayı2;
                txt_ekran.Text = _sonuç.ToString();
            }
            else if (_işlem == "_")
            {
                _sonuç = _sayı - _sayı2;
                txt_ekran.Text = _sonuç.ToString();
            }
        }
    }
}
