using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Test4education
{
    class TurnToBinSys
    {
        public static StringBuilder FromDecimal(int numberInTen)
        {
            var strRes = new StringBuilder(); 
            var tmpStr = new StringBuilder();
            try
            {
                while (numberInTen >= 1)
                {
                    tmpStr.Append(numberInTen % 2);
                    numberInTen /= 2;
                }
                strRes.Append(1);
                for (int i = tmpStr.Length - 1; i >= 0; i--) strRes.Append(tmpStr[i]);

            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("В этом мире можно всё кроме двух вещей: бросать сцепление и делить на ноль");
            }
            return strRes;

        }

    }
}
