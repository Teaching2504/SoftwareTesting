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

namespace Selenium_WebDriver_12_Trinh
{
    public partial class Face_12_Trinh : Form
    {
        public Face_12_Trinh()
        {
            InitializeComponent();
        }

        private void btn_Click_12_Trinh(object sender, EventArgs e)
        {
            // 1.Điều hướng trình duyệt
            IWebDriver driver_12_Trinh = new ChromeDriver();

            // 2. Ra lệnh cho trình duyệt đi đến địa chỉ Google
            driver_12_Trinh.Navigate().GoToUrl("https://facebook.com/");
           
            //1. Email và phone
            //Lấy name
            driver_12_Trinh.FindElement(By.Name("email")).SendKeys("0372210892");

            //2. Password
            //Lấy name
            driver_12_Trinh.FindElement(By.Name("pass")).SendKeys("@Trinh/2504");

            // Sử dụng XPath bạn để Login
            driver_12_Trinh.FindElement(By.XPath("//*[@id=\"login_form\"]/div/div[1]/div/div[3]/div/div/div")).Click();
        }
        private void Face_12_Trinh_Load(object sender, EventArgs e)
        {

        }
    }
}
