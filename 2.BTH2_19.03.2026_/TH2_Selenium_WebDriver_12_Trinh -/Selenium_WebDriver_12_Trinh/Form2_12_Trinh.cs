using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Selenium_WebDriver_12_Trinh
{
    public partial class Form2_12_Trinh : Form
    {
        public Form2_12_Trinh()
        {
            InitializeComponent();
        }

        private void btn_OpenWebDriver_12_Trinh_Click(object sender, EventArgs e)
        {
            string url_12_Trinh = txt_web_12_Trinh.Text.Trim();

            // 2. Nếu ô nhập trống, gán mặc định là Google
            if (string.IsNullOrEmpty(url_12_Trinh))
            {
                url_12_Trinh = "https://www.google.com/";
            }


            // Kiểm tra nếu người dùng quên nhập "https://" thì tự thêm vào để web không bị lỗi
            if (!url_12_Trinh.StartsWith("http"))
            {
                url_12_Trinh = "https://" + url_12_Trinh;
            }

            try
            {
                // 3. Khởi tạo trình duyệt
                IWebDriver driver_12_Trinh = new ChromeDriver();

                //BÀI 4.E Bước 1: Vào Google
                driver_12_Trinh.Navigate().GoToUrl("https://www.google.com/");
                // Dừng 2 giây để xem
                Thread.Sleep(2000); 

                // Bước 2: Vào OU

                driver_12_Trinh.Navigate().GoToUrl("https://ou.edu.vn");
                // Tạm dừng 3 giây để kiểm tra web
                Thread.Sleep(3000);

                //Bài 4.E //
                // Bước 3: Back Google
                driver_12_Trinh.Navigate().Back();
                Thread.Sleep(2000);

                // Bước 4: Forward OU
                driver_12_Trinh.Navigate().Forward();
                Thread.Sleep(2000);

                // Bước 5: Refresh OU
                driver_12_Trinh.Navigate().Refresh();
                Thread.Sleep(2000);

                //BÀI 4.B
                // Lấy tiêu đề trang web và in ra Console
                //Console.WriteLine("Tieu de trang web la: " + driver_12_Trinh.Title);

                // Lấy URL hiện tại và in ra Console
                //Console.WriteLine("URL hien tai la: " + driver_12_Trinh.Url);

                //BÀI 4.C
                // 1. Lấy toàn bộ mã nguồn của trang web vào biến chuỗi
                //string source_12_Trinh = driver_12_Trinh.PageSource;

                // 2. Chỉ lấy một đoạn ngắn (300 ký tự đầu) để in ra 
                //string doan_ngan_12_Trinh = source_12_Trinh.Substring(0, 300);

                // 3. In ra bảng Output/Console
                //Console.WriteLine("--- Mot doan Page Source (300 ky tu dau) ---");
                //Console.WriteLine(doan_ngan_12_Trinh);
                //Console.WriteLine("--------------------------------------------");


               


                //5. Tự động đóng trình duyệt
                driver_12_Trinh.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Trang web bị lỗi: " + ex.Message);
            }
        }
    }
}
