using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_KTPM_UnitTest_12_Trinh
{
    public partial class TinhCSCacHinh_12_Trinh : Form
    {
        public TinhCSCacHinh_12_Trinh()
        {
            InitializeComponent();
        }

        private void cbbHinh_12_Trinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbHinh_12_Trinh.SelectedIndex)
            {

                case 0:
                    lbl4_12_Trinh.Text = "Chiều dài"; lbl4_12_Trinh.Visible = txtCanha_12_Trinh.Visible = true;
                    lbl5_12_Trinh.Text = "Chiều rộng"; lbl5_12_Trinh.Visible = txtCanhb_12_Trinh.Visible = true;
                    lbl6_12_Trinh.Visible = txtCanhc_12_Trinh.Visible = false;
                    break;
                case 1:
                    lbl4_12_Trinh.Text = "Cạnh";
                    lbl4_12_Trinh.Visible = txtCanha_12_Trinh.Visible = true;
                    lbl5_12_Trinh.Visible = lbl6_12_Trinh.Visible = txtCanhb_12_Trinh.Visible = txtCanhc_12_Trinh.Visible = false;
                    break;
                case 2:
                    lbl4_12_Trinh.Text = "Bán Kính"; lbl4_12_Trinh.Visible = txtCanha_12_Trinh.Visible = true;
                    lbl5_12_Trinh.Visible = lbl6_12_Trinh.Visible = txtCanhb_12_Trinh.Visible = txtCanhc_12_Trinh.Visible = false;
                    break;
                case 3:
                    lbl4_12_Trinh.Text = "Cạnh thứ nhất"; lbl4_12_Trinh.Visible = txtCanha_12_Trinh.Visible = true;
                    lbl5_12_Trinh.Text = "Cạnh thứ hai"; lbl5_12_Trinh.Visible = txtCanhb_12_Trinh.Visible = true;
                    lbl6_12_Trinh.Text = "Cạnh thứ ba"; lbl6_12_Trinh.Visible = txtCanhc_12_Trinh.Visible = true;
                    break;
            }
        }

        private void btTinh_12_Trinh_Click(object sender, EventArgs e)
        {
            double ketQua_12_Trinh = 0;

            switch (cbbHinh_12_Trinh.SelectedIndex)
            {
                //1. Hình Chữ Nhật
                case 0:
                    double chieuDai_12_Trinh = double.Parse(txtCanha_12_Trinh.Text);
                    double chieuRong_12_Trinh = double.Parse(txtCanhb_12_Trinh.Text);
                    //Tính Chu Vi Hình Chũ Nhật
                    if (cbbCachTinh_12_Trinh.SelectedIndex == 0)
                        ketQua_12_Trinh = TinhCS_12_Trinh.TinhC_HinhChuNhat_12_Trinh(chieuDai_12_Trinh, chieuRong_12_Trinh);
                    //Tính Diện Tích Hình Chữ Nhật
                    else
                        ketQua_12_Trinh = TinhCS_12_Trinh.TinhS_HinhChuNhat_12_Trinh(chieuDai_12_Trinh, chieuRong_12_Trinh);
                    break;
                //2. Hình Vuông
                case 1:
                    double canh_12_Trinh = double.Parse(txtCanha_12_Trinh.Text);
                    //Tính Chu Vi Hình Vuông
                    if (cbbCachTinh_12_Trinh.SelectedIndex == 0)
                        ketQua_12_Trinh = TinhCS_12_Trinh.TinhC_HinhVuong_12_Trinh(canh_12_Trinh);
                    //Tính Diện Tích Hình Vuông
                    else
                        ketQua_12_Trinh = TinhCS_12_Trinh.TinhS_HinhVuong_12_Trinh(canh_12_Trinh);
                    break;
                //3. Hình Tròn
                case 2:
                    double banKinh_12_Trinh = double.Parse(txtCanha_12_Trinh.Text);
                    //Tính Chu Vi Hình Tròn
                    if (cbbCachTinh_12_Trinh.SelectedIndex == 0)
                        ketQua_12_Trinh = TinhCS_12_Trinh.TinhC_HinhTron_12_Trinh(banKinh_12_Trinh);
                    //Tính Diện Tích Hình Tròn
                    else
                        ketQua_12_Trinh = TinhCS_12_Trinh.TinhS_HinhTron_12_Trinh(banKinh_12_Trinh);
                    break;
                //4. Hình Tam Giác
                case 3:
                    double a_12_Trinh = double.Parse(txtCanha_12_Trinh.Text);
                    double b_12_Trinh = double.Parse(txtCanhb_12_Trinh.Text);
                    double c_12_Trinh = double.Parse(txtCanhc_12_Trinh.Text);
                    //Tính Chu Vi Hình Tam Giác
                    if (cbbCachTinh_12_Trinh.SelectedIndex == 0)
                        ketQua_12_Trinh = TinhCS_12_Trinh.TinhC_HinhTamGiac_12_Trinh(a_12_Trinh, b_12_Trinh, c_12_Trinh);
                    //Tính Diện Tích Hình Tam Giác
                    else
                        ketQua_12_Trinh = TinhCS_12_Trinh.TinhS_HinhTamGiac_12_Trinh(a_12_Trinh, b_12_Trinh, c_12_Trinh);
                    break;
            }
            // Hiển thị kết quả
            txtKetQua_12_Trinh.Text = ketQua_12_Trinh.ToString();
        }
    }
}
