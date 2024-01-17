namespace Bmi  //~ in Java nó là package     
{
    class Program  //a cla mà ko có ừ khoá internal, hoặc
                   //chính chữ inernal thì class này cám
                   //ko cho ai đc dùng bên ngoài namespace của nó
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            double bmi = GetBmi(70, 1.7);
            Console.WriteLine("1. Your BMI is " + bmi); //IN CHUỖI = CÁCH GHÉP QUA TOÁN TỬ + 
                                                        //CONCATENATION 
            Console.WriteLine("2. Your BMI is {0}", bmi); //PLACE HOLDER, ĐIỀN VÀO CHỖ TRÓNG
            Console.WriteLine("3. Your BMI is {0} | {1}", bmi, 2024); //chừa sẵn chỗ trong chuỗi
                                                                    //mỗi chỗ map với 1 biến/value
                                                                      //thứ tự chỗ tính từ 0
            Console.WriteLine($"4. Your BMI is {bmi}"); //interpolation
                                                        //nội suy: ráng tìm trong chuỗi chỗ nào là
                                                        //biến, đoán xem, và fill data
            Console.WriteLine("5. Your BMI is " + bmi);

            //xài class của Class khác NHƯNG...

            Console.WriteLine($"6. Your BMI is {BmiCalculator.GetBmi(70, 1.7)}");

            string healthStatus = BmiCalculator.EvaluateWeightStatus(bmi);

            //@ kĩ thuật in chuỗi nguyên bản raw string
            //gõ gì in nấy, kể cả khoảng trắng, kí tự đặc biệt
            //in giống 100% gõ
            //kĩ thuật này gọi là: VERBATIM
            Console.WriteLine(@$"Your bmi is {bmi}
                
                (based on your weight 70kg
                <html>
                    &gt 5 &gt 7
                  </html>

                and your \n height 1.7m) and your 
                weight status is {healthStatus}");



            Console.ReadLine();
        }

        static double GetBmi(double weight, double height) => weight / (height * height);
        //khi hàm chỉ có 1 cau lẹnh duy nhất, ta dùng cú pháp rút gọn
        //ngay sau tên hàm dùng dấu => kèm câu lệnh duy nhất
        //bỏ luôn cả return
        //cú pháp này gọi là: EXPRESSION BODY - THÂN HÀM VIẾT NHƯ CÔNG THỨC
        //TUYỆT ĐỐI KO NHẦM LẪN EXPRESSION BODY VÀ LAMBDA EXPRESSION
        //SẼ HỌC SAU. 2 THẰNG NÀY ĐỀU XÀI CHUNG KÍ HIỆU =>

        //static double GetBmi(double weight, double height)
        //{
        //    return weight / (height * height);
        //}  //Ctrl K C commen 1 đám code
        //Crl K U un-commen 1 đám code
        //Crl K D: forma lại code cho đẹp rai
        //
    }

    //class khác here!!!
    //class khác khác nữa here!!!
}
