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
    public partial class CustomerId_12_Trinh : Form
    {
        public CustomerId_12_Trinh()
        {
            InitializeComponent();
        }

        private void btn_Customer_12_Trinh_Click(object sender, EventArgs e)
        {

        }

        private void CustomerId_12_Trinh_Load(object sender, EventArgs e)
        {

            IWebDriver driver_12_Trinh = new ChromeDriver();
            driver_12_Trinh.Navigate().GoToUrl("https://demo.guru99.com/test/delete_customer.php");
            Thread.Sleep(2000);
            // 1. Lấy ID của customer
            IWebElement id_12_Trinh = driver_12_Trinh.FindElement(By.Name("cusid"));
            id_12_Trinh.SendKeys("53920");
            Thread.Sleep(2000);
            // 2. Nhấn nút Submit để thực hiện xóa
            IWebElement submit_12_Trinh = driver_12_Trinh.FindElement(By.Name("submit"));
            submit_12_Trinh.Click();
            Thread.Sleep(2000);
            //Nhấn nút OK
            driver_12_Trinh.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
            //Nhấn nút OK lần 2
            driver_12_Trinh.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
        }
    }
}
