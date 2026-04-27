using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_KTPM_UnitTest_12_Trinh
{
    public static class TinhCS_12_Trinh
    {
        //1. Chu vi và diện tích Hình Chữ Nhật
        public static double TinhC_HinhChuNhat_12_Trinh(double length_12_Trinh, double width_12_Trinh)
        {
            // Kiểm tra xem chiều dài và chiều rộng có hợp lệ không
            if (length_12_Trinh <= 0 || width_12_Trinh <= 0) throw new ArgumentException("exception Chiều dài và chiều rộng phải lớn hơn 0.");
            // Tính chu vi hình chữ nhật và làm tròn đến 3 chữ số thập phân
            return Math.Round(2 * (length_12_Trinh + width_12_Trinh), 3);
        }
        public static double TinhS_HinhChuNhat_12_Trinh(double length_12_Trinh, double width_12_Trinh)
        {
            // Kiểm tra xem chiều dài và chiều rộng có hợp lệ không
            if (length_12_Trinh <= 0 || width_12_Trinh <= 0) throw new ArgumentException("exception Chiều dài và chiều rộng phải lớn hơn 0.");
            // Tính diện tích hình chữ nhật và làm tròn đến 3 chữ số thập phân
            return Math.Round(length_12_Trinh * width_12_Trinh, 3);
        }
        //2. Chu vi và Diện tích Hình Vuông
        public static double TinhC_HinhVuong_12_Trinh(double side_12_Trinh)
        {
            // Kiểm tra xem cạnh có hợp lệ không
            if (side_12_Trinh <= 0) throw new ArgumentException("exception Cạnh không thể nhỏ hơn hoặc bằng 0.");
            // Tính chu vi hình vuông và làm tròn đến 3 chữ số thập phân
            return Math.Round(4 * side_12_Trinh, 3);
        }
        public static double TinhS_HinhVuong_12_Trinh(double side_12_Trinh)
        {
            // Kiểm tra xem cạnh có hợp lệ không
            if (side_12_Trinh <= 0) throw new ArgumentException("exception Cạnh không thể nhỏ hơn hoặc bằng 0.");
            // Tính diện tích hình vuông và làm tròn đến 3 chữ số thập phân
            return Math.Round(side_12_Trinh * side_12_Trinh, 3);
        }
        //3. Chu vi và Diện tích Hình Tròn
        public static double TinhC_HinhTron_12_Trinh(double radius_12_Trinh)
        {
            // Kiểm tra xem bán kính có âm không
            if (radius_12_Trinh < 0) throw new ArgumentException("exception Bán kính không thể âm.");
            // Tính chu vi hình tròn và làm tròn đến 3 chữ số thập phân
            return Math.Round(2 * Math.PI * radius_12_Trinh, 3);
        }
        public static double TinhS_HinhTron_12_Trinh(double radius_12_Trinh)
        {
            // Kiểm tra xem bán kính có âm không
            if (radius_12_Trinh < 0) throw new ArgumentException("exception Bán kính không thể âm.");
            // Tính diện tích hình tròn và làm tròn đến 3 chữ số thập phân
            return Math.Round(Math.PI * radius_12_Trinh * radius_12_Trinh, 3);
        }
        //4. Chu vi và Diện tích Hình Tam Giác
        public static double TinhC_HinhTamGiac_12_Trinh(double a_12_Trinh, double b_12_Trinh, double c_12_Trinh)
        {
            // Kiểm tra xem các cạnh có hợp lệ không
            if (a_12_Trinh <= 0 || b_12_Trinh <= 0 || c_12_Trinh <= 0) throw new ArgumentException("exception Cạnh của tam giác phải lớn hơn 0.");
            // Kiểm tra bất đẳng thức tam giác
            if (a_12_Trinh + b_12_Trinh <= c_12_Trinh || a_12_Trinh + c_12_Trinh <= b_12_Trinh || b_12_Trinh + c_12_Trinh <= a_12_Trinh)
                throw new ArgumentException("exception Không thỏa mãn bất đẳng thức tam giác.");
            // Tính chu vi hình tam giác và làm tròn đến 3 chữ số thập phân
            return Math.Round(a_12_Trinh + b_12_Trinh + c_12_Trinh, 3);
        }
        public static double TinhS_HinhTamGiac_12_Trinh(double a_12_Trinh, double b_12_Trinh, double c_12_Trinh)
        {
            // Kiểm tra xem các cạnh có hợp lệ không
            if (a_12_Trinh <= 0 || b_12_Trinh <= 0 || c_12_Trinh <= 0) throw new ArgumentException("exception Cạnh của tam giác phải lớn hơn 0.");
            // Kiểm tra bất đẳng thức tam giác
            if (a_12_Trinh + b_12_Trinh <= c_12_Trinh || a_12_Trinh + c_12_Trinh <= b_12_Trinh || b_12_Trinh + c_12_Trinh <= a_12_Trinh)
                throw new ArgumentException("exception Không thỏa mãn bất đẳng thức tam giác.");
            // Tính diện tích tam giác bằng công thức Heron
            double s_12_Trinh = (a_12_Trinh + b_12_Trinh + c_12_Trinh) / 2;
            return Math.Round(Math.Sqrt(s_12_Trinh * (s_12_Trinh - a_12_Trinh) * (s_12_Trinh - b_12_Trinh) * (s_12_Trinh - c_12_Trinh)), 3);
        }
    }
}
