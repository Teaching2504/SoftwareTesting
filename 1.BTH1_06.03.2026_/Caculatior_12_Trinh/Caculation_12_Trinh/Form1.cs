using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator_12_Trinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bthCong_12_Trinh_Click(object sender_12_Trinh, EventArgs e_12_Trinh)
        {
            int a_12_Trinh, b_12_Trinh, ketqua_12_Trinh;
            a_12_Trinh = int.Parse(txt_So_1_12_Trinh.Text);
            b_12_Trinh = int.Parse(txt_So_2_12_Trinh.Text);
            Caculation_12_Trinh c = new Caculation_12_Trinh(a_12_Trinh, b_12_Trinh);
            ketqua_12_Trinh = c.Execute_12_Trinh("+");
            txt_KQ_12_Trinh.Text = ketqua_12_Trinh.ToString();
        }
        private void bthTru_12_Trinh_Click(object sender_12_Trinh, EventArgs e_12_Trinh)
        {
            int a_12_Trinh, b_12_Trinh, ketqua_12_Trinh;
            a_12_Trinh = int.Parse(txt_So_1_12_Trinh.Text);
            b_12_Trinh = int.Parse(txt_So_2_12_Trinh.Text);
            Caculation_12_Trinh c = new Caculation_12_Trinh(a_12_Trinh, b_12_Trinh);
            ketqua_12_Trinh = c.Execute_12_Trinh("-");
            txt_KQ_12_Trinh.Text = ketqua_12_Trinh.ToString();
        }
        private void bthNhan_12_Trinh_Click(object sender_12_Trinh, EventArgs e_12_Trinh)
        {
            int a_12_Trinh, b_12_Trinh, ketqua_12_Trinh;
            a_12_Trinh = int.Parse(txt_So_1_12_Trinh.Text);
            b_12_Trinh = int.Parse(txt_So_2_12_Trinh.Text);
            Caculation_12_Trinh c = new Caculation_12_Trinh(a_12_Trinh, b_12_Trinh);
            ketqua_12_Trinh = c.Execute_12_Trinh("*");
            txt_KQ_12_Trinh.Text = ketqua_12_Trinh.ToString();
        }
        private void bthChia_12_Trinh_Click(object sender_12_Trinh, EventArgs e_12_Trinh)
        {
            int a_12_Trinh, b_12_Trinh, ketqua_12_Trinh;
            a_12_Trinh = int.Parse(txt_So_1_12_Trinh.Text);
            b_12_Trinh = int.Parse(txt_So_2_12_Trinh.Text);
            Caculation_12_Trinh c = new Caculation_12_Trinh(a_12_Trinh, b_12_Trinh);
            ketqua_12_Trinh = c.Execute_12_Trinh("/");
            txt_KQ_12_Trinh.Text = ketqua_12_Trinh.ToString();
        }
      
    }
}
