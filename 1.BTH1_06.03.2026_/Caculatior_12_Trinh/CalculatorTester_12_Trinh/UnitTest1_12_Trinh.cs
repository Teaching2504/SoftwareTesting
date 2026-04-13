using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Caculator_12_Trinh;
namespace CalculatorTester_12_Trinh
{
    [TestClass]
    public class UnitTest1_12_Trinh
    {
        public TestContext TestContext { get; set; }
        private Caculation_12_Trinh c_12_Trinh;
        [TestInitialize]
        // thiet lap du lieu dung chung cho TC
        public void SetUp_12_Trinh()
        {
            c_12_Trinh = new Caculation_12_Trinh(23, 25);
        }
        [TestMethod]
        //TC1: a =23, b = 25, kq= 48
        public void TC1_Test_Cong_12_Trinh()
        {
            int expected_12_Trinh, actual_12_Trinh;
            // Caculation c = new Caculation(a,b);
            expected_12_Trinh = 48;
            actual_12_Trinh = c_12_Trinh.Execute_12_Trinh("+");
            Assert.AreEqual(expected_12_Trinh, actual_12_Trinh);

        }
     
        //TC2
        [TestMethod]
        public void TC2_Test_Tru_12_Trinh()
        {
            int expected_12_Trinh, actual_12_Trinh;
            expected_12_Trinh = -2;
            actual_12_Trinh = c_12_Trinh.Execute_12_Trinh("-");
            Assert.AreEqual(expected_12_Trinh, actual_12_Trinh);
        }

        //TC3
        [TestMethod]
        public void TC3_Test_Nhan_12_Trinh()
        {
            int expected_12_Trinh, actual_12_Trinh;
            expected_12_Trinh = 575;
            actual_12_Trinh = c_12_Trinh.Execute_12_Trinh("*");
            Assert.AreEqual(expected_12_Trinh, actual_12_Trinh);
        }

        //TC4
        [TestMethod]
        public void TC4_Test_Chia_12_Trinh()
        {
            int expected_12_Trinh, actual_12_Trinh;
            expected_12_Trinh = 0; 
            // 23 chia nguyên cho 25 bằng 0
            actual_12_Trinh = c_12_Trinh.Execute_12_Trinh("/");
            Assert.AreEqual(expected_12_Trinh, actual_12_Trinh);
        }

        //TC5
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TC5_Test_ChiaZero_12_Trinh()
        {
            // Khởi tạo bộ số mới có số chia là 0 để kiểm tra lỗi
            c_12_Trinh = new Caculator_12_Trinh.Caculation_12_Trinh(10, 0);
            c_12_Trinh.Execute_12_Trinh("/");
        }

        //TC6 CONG FILE CSV
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                     @"data\TestData_12_Trinh.csv",
                     "TestData_12_Trinh#csv",
             DataAccessMethod.Sequential)]
        [TestMethod]
        public void TC6_Test_CongCSV_12_Trinh()
        {
            // 1. Lấy dữ liệu từ DataRow theo chỉ số [0, 1, 2]
            int a_12_Trinh = int.Parse(TestContext.DataRow[0].ToString());
            int b_12_Trinh = int.Parse(TestContext.DataRow[1].ToString());
            int expected_12_Trinh = int.Parse(TestContext.DataRow[2].ToString());

            // 2. Khởi tạo đối tượng và thực hiện phép cộng "+"
            c_12_Trinh = new Caculation_12_Trinh(a_12_Trinh, b_12_Trinh);
            int actual_12_Trinh = c_12_Trinh.Execute_12_Trinh("+");

            // 3. So sánh kết quả
            Assert.AreEqual(expected_12_Trinh, actual_12_Trinh);
        }

        //TC7 - Kiểm thử với file csv 4 dòng

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                 @"|DataDirectory|\data\DataTest_cotToanTu_12_Trinh.csv",
                 "DataTest_cotToanTu_12_Trinh#csv",
                 DataAccessMethod.Sequential)]
        [TestMethod]
        public void TC7_Test_FileCSV_12_Trinh()
        {
            // 1. Lấy dữ liệu theo chỉ số cột (0, 1, 2, 3)
            int a_12_Trinh = int.Parse(TestContext.DataRow[0].ToString());
            int b_12_Trinh = int.Parse(TestContext.DataRow[1].ToString());

            // Dùng Replace để xóa dấu nháy đơn (') trước toán tử
            // Ví dụ: "'+ " sẽ trở thành "+"
            string operation_12_Trinh = TestContext.DataRow[2].ToString().Replace("'", "").Trim();
            int expected_12_Trinh = int.Parse(TestContext.DataRow[3].ToString());

            // 2. Thực thi kiểm thử
            c_12_Trinh = new Caculation_12_Trinh(a_12_Trinh, b_12_Trinh);
            int actual_12_Trinh = c_12_Trinh.Execute_12_Trinh(operation_12_Trinh);

            // 3. So sánh kết quả
            Assert.AreEqual(expected_12_Trinh, actual_12_Trinh);
        }

    }
}