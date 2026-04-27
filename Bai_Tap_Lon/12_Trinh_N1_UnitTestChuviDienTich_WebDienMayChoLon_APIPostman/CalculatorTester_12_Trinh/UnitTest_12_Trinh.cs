using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BTL_KTPM_UnitTest_12_Trinh;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace CalculatorTester_12_Trinh
{
    [TestClass]
    public class UnitTest_12_Trinh
    {
        //TC1: Chu vi hình Chữ nhật 
        [TestMethod]
        public void TC1_TestTinhC_HinhChuNhat_12_Trinh()
        {
            // Gán giá trị cho chiều dài và rộng của hình chữ nhật 
            double chieuDai_12_Trinh = 3;
            double chieuRong_12_Trinh = 5;
            // 2 * (3 + 5)
            double expected_12_Trinh = 16.000;
            double actual_12_Trinh = TinhCS_12_Trinh.TinhC_HinhChuNhat_12_Trinh(chieuDai_12_Trinh, chieuRong_12_Trinh);
            Assert.AreEqual(expected_12_Trinh, actual_12_Trinh, 0.001);
        }
        //TC2: Diện tích Hình Chữ Nhật
        [TestMethod]
        public void TC2_TestTinhS_HinhChuNhat_12_Trinh()
        {
            // Gán giá trị cho chiều dài và rộng của hình chữ nhật 
            double chieuDai_12_Trinh = 2;
            double chieuRong_12_Trinh = 5;
            // 2*5
            double expected_12_Trinh = 10.000;
            double actual_12_Trinh = TinhCS_12_Trinh.TinhS_HinhChuNhat_12_Trinh(chieuDai_12_Trinh, chieuRong_12_Trinh);
            Assert.AreEqual(expected_12_Trinh, actual_12_Trinh, 0.001);
        }
        //TC3: Chu vi Hình Vuông
        [TestMethod]
        public void TC3_TestTinhC_HinhVuong_12_Trinh()
        {
            // Gán giá trị cho cạnh của hình vuông
            double canh_12_Trinh = 4;
            // 4 * 4
            double expected_12_Trinh = 16.000;
            double actual_12_Trinh = TinhCS_12_Trinh.TinhC_HinhVuong_12_Trinh(canh_12_Trinh);
            Assert.AreEqual(expected_12_Trinh, actual_12_Trinh, 0.001);
        }
        //TC4: Diện tích Hình Vuông
        [TestMethod]
        public void TC4_TestTinhS_HinhVuong_12_Trinh()
        {
            // Gán giá trị cho cạnh của hình vuông
            double canh_12_Trinh = 9;
            //9*9
            double expected_12_Trinh = 81.000;
            double actual_12_Trinh = TinhCS_12_Trinh.TinhS_HinhVuong_12_Trinh(canh_12_Trinh);
            Assert.AreEqual(expected_12_Trinh, actual_12_Trinh, 0.001);
        }
        //TC5: Tính Chu Vi Hình Tròn
        [TestMethod]
        public void TC5_TestTinhC_HinhTron_12_Trinh()
        {
            // Gán giá trị cho bán kính 
            double banKinh_12_Trinh = 5;
            // 2 * π * 5
            double expected_12_Trinh = 31.416;
            double actual_12_Trinh= TinhCS_12_Trinh.TinhC_HinhTron_12_Trinh(banKinh_12_Trinh);
            Assert.AreEqual(expected_12_Trinh, actual_12_Trinh, 0.001);
        }
        //TC6: Tính Diện tích Hình Tròn
        [TestMethod]
        public void TC6_TestTinhS_HinhTron_12_Trinh()
        {
            // Gán giá trị cho bán kính 
            double banKinh_12_Trinh = 7;
            // π * 7^2
            double expected_12_Trinh = 153.938;
            double actual_12_Trinh = TinhCS_12_Trinh.TinhS_HinhTron_12_Trinh(banKinh_12_Trinh);
            Assert.AreEqual(expected_12_Trinh, actual_12_Trinh, 0.001);
        }
        //TC7: Tính Chu vi Hình Tam Giác
        [TestMethod]
        public void TC7_TestTinhC_HinhTamGiac_12_Trinh()
        {
            // Gán giá trị cho 3 cạnh của hình tam giác 
            double a_12_Trinh = 2;
            double b_12_Trinh = 4;
            double c_12_Trinh = 5;
            // 2 + 4 + 5
            double expected_12_Trinh = 11.000;
            double actual_12_Trinh = TinhCS_12_Trinh.TinhC_HinhTamGiac_12_Trinh(a_12_Trinh, b_12_Trinh, c_12_Trinh);
            Assert.AreEqual(expected_12_Trinh, actual_12_Trinh, 0.001);
        }
        //TC8: Tính Diện tích Hình Tam Giác
        [TestMethod]
        public void TC8_TestTinhS_HinhTamGiac_12_Trinh()
        {
            // Gán giá trị cho 3 cạnh của hình tam giác 
            double a_12_Trinh = 2;
            double b_12_Trinh = 4;
            double c_12_Trinh = 5;
            // Diện tích tam giác với cạnh 2, 4, 5
            double expected_12_Trinh = 3.800;
            double actual_12_Trinh = TinhCS_12_Trinh.TinhS_HinhTamGiac_12_Trinh(a_12_Trinh, b_12_Trinh, c_12_Trinh);
            Assert.AreEqual(expected_12_Trinh, actual_12_Trinh, 0.001);
        }
        //TC9: test file csv Tính Chu Vi Các Hình
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    @"data_12_Trinh\TestDataC_12_Trinh.csv",
                    "TestDataC_12_Trinh#csv",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void TC9_TestC_CSV_12_Trinh()
        {
            // 1. Khai báo và lấy dữ liệu từ các cột trong file CSV dựa trên chỉ số 
            string shape_12_Trinh = TestContext.DataRow[0].ToString();
            string a1_12_Trinh = TestContext.DataRow[1].ToString();
            string b1_12_Trinh = TestContext.DataRow[2].ToString();
            string c1_12_Trinh = TestContext.DataRow[3].ToString();
            string expected_12_Trinh = TestContext.DataRow[4].ToString();

            double result_12_Trinh = 0;
            bool isPassed_12_Trinh = false;
            string errorMsg_12_Trinh = "";
            try
            {

                // 2. Chuyển đổi dữ liệu chuỗi sang số thực (dùng CultureInfo.InvariantCulture để tránh lỗi dấu chấm/phẩy)
                double a_12_Trinh = double.Parse(a1_12_Trinh, System.Globalization.CultureInfo.InvariantCulture);
                double b_12_Trinh = double.Parse(b1_12_Trinh, System.Globalization.CultureInfo.InvariantCulture);
                double c_12_Trinh = double.Parse(c1_12_Trinh, System.Globalization.CultureInfo.InvariantCulture);

                // 3. Phân loại hình học và gọi hàm tính Chu vi tương ứng
                switch (shape_12_Trinh)
                {
                    case "HinhChuNhat":
                        result_12_Trinh = TinhCS_12_Trinh.TinhC_HinhChuNhat_12_Trinh(a_12_Trinh, b_12_Trinh);
                        break;
                    case "HinhVuong":
                        result_12_Trinh = TinhCS_12_Trinh.TinhC_HinhVuong_12_Trinh(a_12_Trinh);
                        break;
                    case "HinhTron":
                        result_12_Trinh = TinhCS_12_Trinh.TinhC_HinhTron_12_Trinh(a_12_Trinh);
                        break;
                    case "HinhTamGiac":
                        result_12_Trinh = TinhCS_12_Trinh.TinhC_HinhTamGiac_12_Trinh(a_12_Trinh, b_12_Trinh, c_12_Trinh);
                        break;
                    default:
                        throw new ArgumentException("Loại hình không hợp lệ");
                }
                // 4. Kiểm tra kết quả nếu hàm chạy bình thường
                // Kiểm tra xem trong CSV có phải đang mong chờ Exception không
                if (expected_12_Trinh.Trim().Equals("exception", StringComparison.OrdinalIgnoreCase))
                {
                    isPassed_12_Trinh = false;
                }
                else
                {
                    // So sánh kết quả tính toán với giá trị mong đợi trong CSV
                    double expectedValue = double.Parse(expected_12_Trinh.Trim(), CultureInfo.InvariantCulture);
                    if (Math.Abs(result_12_Trinh - expectedValue) < 0.001) isPassed_12_Trinh = true;
                    else errorMsg_12_Trinh = $"Sai số: {result_12_Trinh} != {expectedValue}";
                }
            }
            catch (Exception ex_12_Trinh)
            {
                /// 5. Nếu hàm ném ra Exception (ví dụ: do số âm)
                // Kiểm tra xem trong CSV có cột expected là "exception" không
                if (expected_12_Trinh.Trim().Equals("exception", StringComparison.OrdinalIgnoreCase))
                {
                    isPassed_12_Trinh = true;
                }
                else
                {
                    isPassed_12_Trinh = false;
                    errorMsg_12_Trinh = ex_12_Trinh.Message;
                }
            }
        }
        //TC10: test file csv Tính Diện Tích Các Hình
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    @"data_12_Trinh\TestDataS_12_Trinh.csv",
                    "TestDataS_12_Trinh#csv",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void TC10_TestS_CSV_12_Trinh()
        {
            // 1. Khai báo và lấy dữ liệu từ các cột trong file CSV dựa trên chỉ số 
            string shape_12_Trinh = TestContext.DataRow[0].ToString();
            string a1_12_Trinh = TestContext.DataRow[1].ToString();
            string b1_12_Trinh = TestContext.DataRow[2].ToString();
            string c1_12_Trinh = TestContext.DataRow[3].ToString();
            string expected_12_Trinh = TestContext.DataRow[4].ToString();
            double result_12_Trinh = 0;
            bool isPassed_12_Trinh = false;
            string errorMsg_12_Trinh = "";
            try
            {

                // 2. Chuyển đổi dữ liệu chuỗi sang số thực (dùng CultureInfo.InvariantCulture để tránh lỗi dấu chấm/phẩy)
                double a_12_Trinh = double.Parse(a1_12_Trinh, System.Globalization.CultureInfo.InvariantCulture);
                double b_12_Trinh = double.Parse(b1_12_Trinh, System.Globalization.CultureInfo.InvariantCulture);
                double c_12_Trinh = double.Parse(c1_12_Trinh, System.Globalization.CultureInfo.InvariantCulture);

                // 3. Phân loại hình học và gọi hàm tính Diện tích tương ứng
                switch (shape_12_Trinh)
                {
                    case "HinhChuNhat":
                        result_12_Trinh = TinhCS_12_Trinh.TinhS_HinhChuNhat_12_Trinh(a_12_Trinh, b_12_Trinh);
                        break;
                    case "HinhVuong":
                        result_12_Trinh = TinhCS_12_Trinh.TinhS_HinhVuong_12_Trinh(a_12_Trinh);
                        break;
                    case "HinhTron":
                        result_12_Trinh = TinhCS_12_Trinh.TinhS_HinhTron_12_Trinh(a_12_Trinh);
                        break;
                    case "HinhTamGiac":
                        result_12_Trinh = TinhCS_12_Trinh.TinhS_HinhTamGiac_12_Trinh(a_12_Trinh, b_12_Trinh, c_12_Trinh);
                        break;
                    default:
                        throw new ArgumentException("Loại hình không hợp lệ");
                }
                // 4. Kiểm tra kết quả nếu hàm chạy bình thường
                // Kiểm tra xem trong CSV có phải đang mong chờ Exception không
                if (expected_12_Trinh.Trim().Equals("exception", StringComparison.OrdinalIgnoreCase))
                {
                    isPassed_12_Trinh = false;
                }
                else
                {
                    // So sánh kết quả tính toán với giá trị mong đợi trong CSV
                    double expectedValue = double.Parse(expected_12_Trinh.Trim(), CultureInfo.InvariantCulture);
                    if (Math.Abs(result_12_Trinh - expectedValue) < 0.001) isPassed_12_Trinh = true;
                    else errorMsg_12_Trinh = $"Sai số: {result_12_Trinh} != {expectedValue}";
                }
            }
            catch (Exception ex_12_Trinh)
            {
                // 5. Nếu hàm ném ra Exception (ví dụ: do số âm)
                // Kiểm tra xem trong CSV có cột expected là "exception" không
                if (expected_12_Trinh.Trim().Equals("exception", StringComparison.OrdinalIgnoreCase))
                {
                    isPassed_12_Trinh = true;
                }
                else
                {
                    isPassed_12_Trinh = false;
                    errorMsg_12_Trinh = ex_12_Trinh.Message;
                }
            }
        }
    }
}
