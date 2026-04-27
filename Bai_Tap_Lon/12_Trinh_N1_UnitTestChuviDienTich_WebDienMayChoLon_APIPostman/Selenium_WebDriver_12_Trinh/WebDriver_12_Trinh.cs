using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_WebDriver_12_Trinh
{
    public partial class WebDriver_12_Trinh : Form
    {
        public WebDriver_12_Trinh()
        {
            InitializeComponent();
        }
        //Chức năng 1: Đăng nhập hệ thống
        private void btn1_LoginClick_12_Trinh(object sender, EventArgs e)
        {
            // 1.Điều hướng trình duyệt
            IWebDriver driver_12_Trinh = new ChromeDriver();
            // 2. Ra lệnh cho trình duyệt đi đến địa chỉ điện máy chợ lớn
            driver_12_Trinh.Navigate().GoToUrl("https://dienmaycholon.com/dang-nhap");
            //Cấu hình trình duyệt mở full màn hình
            driver_12_Trinh.Manage().Window.FullScreen();
            // 1.Email và phone
            //Lấy name
            driver_12_Trinh.FindElement(By.Name("username")).SendKeys("Teaching2504");
            Thread.Sleep(2000);
            //2. Password
            //lấy id
            driver_12_Trinh.FindElement(By.Id("password")).SendKeys("@Trinh/2504");
            Thread.Sleep(2000);
            // Sử dụng XPath để Login
            driver_12_Trinh.FindElement(By.XPath("//*[@id='f_login']/div[4]/button/span")).Click();
            //Chờ 5 giây để xem kết quả và thoát màn hình
            Thread.Sleep(5000);
            driver_12_Trinh.Quit();
        }
        //Chức năng 2: Bộ lọc sản phẩm thông minh
        private void btn2_FilterClick_12_Trinh(object sender, EventArgs e)
        {
            // 1.Điều hướng trình duyệt
            IWebDriver driver_12_Trinh = new ChromeDriver();
            // 2. Ra lệnh cho trình duyệt đi đến địa chỉ điện máy chợ lớn
            driver_12_Trinh.Navigate().GoToUrl("https://dienmaycholon.com/");
            //Cấu hình trình duyệt mở full màn hình
            driver_12_Trinh.Manage().Window.FullScreen();
            // Sử dụng class name để tìm kiếm 
            driver_12_Trinh.FindElement(By.ClassName("search_mb")).Click();
            Thread.Sleep(2000);
            //Tìm kiếm theo gợi ý thứ nhất
            driver_12_Trinh.FindElement(By.XPath("//*[@id='search-result']/ul/li[1]/a")).Click();
            Thread.Sleep(2000);
            //Cấu hình trình duyệt mở full màn hình
            driver_12_Trinh.Manage().Window.FullScreen();
            //Nhấn vào nút bộ lọc bằng ClassName
            driver_12_Trinh.FindElement(By.ClassName("filter-item__title")).Click();
            Thread.Sleep(2000);
            //Lọc loại tủ lạnh Panasonic bằng XPath
            driver_12_Trinh.FindElement(By.XPath("//*[@id='js-scroll']/div[1]/div[2]/div[1]/div[1]/div/div/div/div[1]/div[3]/div/div[2]/div/a[1]/img")).Click();
            Thread.Sleep(2000);
            //Nhấn đóng để lọc theo điều kiện đã chọn theo ClassName
            driver_12_Trinh.FindElement(By.ClassName("close-popup-total")).Click();
            //Dừng 5S và Thoát màn hình
            Thread.Sleep(5000);
            driver_12_Trinh.Quit();
        }
        //Chức năng 3: Kiểm tra xem đánh giá sản phẩm
        private void btn3_CommentClick_12_Trinh(object sender, EventArgs e)
        {
            // 1.Điều hướng trình duyệt
            IWebDriver driver_12_Trinh = new ChromeDriver();
            // 2. Ra lệnh cho trình duyệt đi đến địa chỉ điện máy chợ lớn
            driver_12_Trinh.Navigate().GoToUrl("https://dienmaycholon.com/");
            //Cấu hình trình duyệt mở full màn hình
            driver_12_Trinh.Manage().Window.FullScreen();
            //Sử dụng classname để tìm kiếm
            driver_12_Trinh.FindElement(By.ClassName("search_mb")).Click();
            Thread.Sleep(2000);
            //Tìm kiếm theo gợi ý thứ hai theo XPath
            driver_12_Trinh.FindElement(By.XPath("//*[@id='search-result']/ul/li[2]/a")).Click();
            Thread.Sleep(2000);
            //Xem sản phẩm đầu tiên gợi ý bằng XPath
            driver_12_Trinh.FindElement(By.XPath("//*[@id='js-scroll']/div[1]/div[2]/div[2]/div/div[1]/div[1]/a/img")).Click();
            Thread.Sleep(2000);
            //Kiểm tra đánh giá bằng XPath
            driver_12_Trinh.FindElement(By.XPath("//*[@id='product_detail']/section/div[1]/div[1]/div/div[2]/div[2]/div[2]/div[4]/a")).Click();
            Thread.Sleep(10000);
            //Dừng 5S và Thoát màn hình
            Thread.Sleep(5000);
            driver_12_Trinh.Quit();
        }
        //Chức năng 4: Quản lý Giỏ hàng
        private void btn4_CartClick_12_Trinh(object sender, EventArgs e)
        {
            // 1.Điều hướng trình duyệt
            IWebDriver driver_12_Trinh = new ChromeDriver();
            // 2. Ra lệnh cho trình duyệt đi đến địa chỉ điện máy chợ lớn
            driver_12_Trinh.Navigate().GoToUrl("https://dienmaycholon.com/");
            //Cấu hình trình duyệt mở full màn hình
            driver_12_Trinh.Manage().Window.FullScreen();
            //Sử dụng classname để tìm kiếm
            driver_12_Trinh.FindElement(By.ClassName("search_mb")).Click();
            Thread.Sleep(2000);
            //Nhập từ khóa tìm kiếm là tủ lạnh bằng CssSelector
            driver_12_Trinh.FindElement(By.CssSelector("input[placeholder='Bạn cần tìm gì?']")).SendKeys("tulanh");
            Thread.Sleep(2000);
            //Nhấn biểu tượng tìm kiếm
            driver_12_Trinh.FindElement(By.ClassName("button_search")).Click();
            Thread.Sleep(2000);
            //Xem toàn màn hình
            driver_12_Trinh.Manage().Window.FullScreen();
            Thread.Sleep(2000);
            //Lấy sản phẩm bằng XPath
            driver_12_Trinh.FindElement(By.XPath("//*[@id='js-scroll']/div[2]/div[3]/div/div/div[2]/div[1]/div[1]/div[1]/a/img")).Click();
            Thread.Sleep(2000);
            //Xem toàn màn hình
            driver_12_Trinh.Manage().Window.FullScreen();
            Thread.Sleep(2000);
            //Chọn mua sản phẩm để thêm sản phẩm vào giỏ hàng và kiểm tra sản phẩm
            driver_12_Trinh.FindElement(By.ClassName("click_buy")).Click();
            Thread.Sleep(2000);
            driver_12_Trinh.Manage().Window.FullScreen();
            //Dừng 5S và Thoát màn hình
            Thread.Sleep(5000);
            driver_12_Trinh.Quit();
        }
    }
}
