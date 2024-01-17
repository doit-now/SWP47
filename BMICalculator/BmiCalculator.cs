using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmi
{
    public class BmiCalculator  //cám ben ngoai namepace xài class này
    {                             //neu xài inernal
        public static double GetBmi(double weight, double height) => weight / (height * height);
   
        //công thức tính nhanh cân nặng phù hợp với bạn
        //1.7m -> 170 cm - 100 = 70kg
        //m đổi qua cm - 100 -> cân nặng phù hợp quanh chút con số này

        //String, string are equal
        //Tên hàm/method dùng quy tắc Pascal Case Notation
        public static string EvaluateWeightStatus(double bmi)
        {
            if (bmi < 18.5) 
                return "Underweight";
            //ko cần else ở dưới đây
            if (bmi < 25)
                return "You are the perfect on in body shape and weight";
            if (bmi < 30)
                return "Overweight";  //mập 1 tí
            return "Obese";  //béo phì

        }

    }
}
