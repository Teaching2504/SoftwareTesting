using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator_12_Trinh
{
    public class Caculation_12_Trinh
    {
        private int a_12_Trinh, b_12_Trinh;

        public Caculation_12_Trinh(int a_12_Trinh, int b_12_Trinh)
        {
            this.a_12_Trinh = a_12_Trinh;
            this.b_12_Trinh = b_12_Trinh;
        }

        public int Execute_12_Trinh(string CalSymbol_12_Trinh)
        {
            int result = 0;
            switch (CalSymbol_12_Trinh)
            {
                case "+":
                    result = this.a_12_Trinh + this.b_12_Trinh;
                    break;
                case "-":
                    result = this.a_12_Trinh - this.b_12_Trinh;
                    break;
                case "*":
                    result = this.a_12_Trinh * this.b_12_Trinh;
                    break;
                case "/":
                    result = this.a_12_Trinh / this.b_12_Trinh;
                    break;
            }
            return result;
        }
    }
}
