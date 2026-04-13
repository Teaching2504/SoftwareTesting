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
    public partial class Upload_12_Trinh : Form
    {
        public Upload_12_Trinh()
        {
            InitializeComponent();
        }

        private void btn1_Click_12_Trinh(object sender, EventArgs e)
        {
            IWebDriver driver_12_Trinh = new ChromeDriver();
            driver_12_Trinh.Navigate().GoToUrl("https://demo.guru99.com/test/upload/");
            Thread.Sleep(2000);
            //1.Upload file
            IWebElement upload_12_Trinh = driver_12_Trinh.FindElement(By.Id("uploadfile_0"));
            upload_12_Trinh.SendKeys(@"E:\DemoImage.png");
            Thread.Sleep(2000);
            //2. Tích chọn
            IWebElement check_12_Trinh = driver_12_Trinh.FindElement(By.Id("terms"));
            check_12_Trinh.Click();
            Thread.Sleep(2000);
            //3. Nhấn Submit
            IWebElement submit_12_Trinh = driver_12_Trinh.FindElement(By.Name("send"));
            submit_12_Trinh.Click();
            Thread.Sleep(2000);
        }
    }
}
