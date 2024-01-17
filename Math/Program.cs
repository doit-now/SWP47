using Bmi;  //~ import bên Java

namespace Math //default, VS lấy tên project
    //thư mục chứa project làm căn phòng chứa 
    //các class, tên project dùng để chia nhóm class
    //giống như dto, dao bên Java
    //căn phòng chứa các class liên quan gọi là namespace
    //1 khu vực/folder nơi tìm thấy nhiều class cùng liên quan

{
    internal class Program //internal, ko có internal đều mang 
                           //cùng ý nghĩa là private
                           //còn có thêm public, private, default (ko ghi gì - che giấu)
                           //protected => CẤP QUYỀN TRUY XUẤT
                           //ACCESSOR, ACCESS MODIFIER, ACCESS SPECIFIER
    {
        //svm ~ psvm bên NetBeans, tạo hàm Main()



        static void Main(string[] args)
        {
            int sumAll;
            int sumOdd = 2024;  //chơi với ref cần 1 giá trị default
            //cho biến ref trước khi truyền vào
            //để đề phòng ref ko có value từ hàm thì vẫn còn value
            //default sau khi gọi hàm
            //login phía sau: gọi hàm phải đc value

            sumAll = SumOddIntegerList(ref sumOdd);
            Console.WriteLine("Odd sum: " + sumOdd);
        }

        //ref cũng là pass by reference
        static int SumOddIntegerList(ref int sumOddNums)
        {
            int sumAll = 0, sumOdd = 0;

            for (int i = 1; i <= 10; i++)
            {
                sumAll += i;
                if (i % 2 != 0) //có là lẻ ko
                    sumOdd += i;
            }

            //ref ko ép chúng ta phải gán giá trị cho biến ref
            //lỏng lẻo hơn so với out

            //nếu ko mún default, thì gán ref
            //nhưng ko bắt buộc
            sumOddNums = sumOdd;
            
            return sumAll;
        }




        //static void Main(string[] args)
        //{
        //    int sumAll, sumEven = 10;

        //    sumAll = SumIntegerList(out sumEven);

        //    Console.WriteLine("Sum even: " + sumEven);
        //}



        //static void Main(string[] args)
        //{
        //    //CheckReadOnlyParam(10);
        //    int sumA;

        //    sumA = SumIntegerList();
        //    //Console.WriteLine("Sum all: " + sumA);
        //    Console.WriteLine($"Sum all: {sumA}");
        //}

        //học 2 keyword mới: "ref" và "out"
        //tính tổng các số từ 1...10
        //1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10
        //11 x 5 = 55
        //tính tổng các số chẵn
        //2 + 4 + 6 + 8 + 10 = 30

        //câu hỏi phỏng vấn: phân biệt OVERRIDE VÀ OVERLOAD
        //OVERLOAD/OVERLOADING: LÀ HIỆN TƯỢNG CÓ THỂ XẢY RA TRONG
        //BẤT KÌ CLASS NÀO KHI TRONG CLASS ĐÓ CÓ NHIỀU HÀM TRÙNG
        //TÊN NHAU NHƯNG KHÁC PHẦN THAM SỐ ĐẦU VÀO
        //KHÁC NGHĨA LÀ KHÁC TRÊN KIỂU DỮ LIỆU ĐẦU VÀO
        //CHỨ KHÁC TÊN BIẾN ĐẦU VÀO LÀ VÔ NGHĨA
        //TÊN HÀM TRÙNG NHAU NHƯNG KHÁC PHẦN THAM SỐ TRÊN DATA TYPE
        //VÍ DỤ:

        //void FOk(int n) { }
        //void FOk(double n) { }

        //OVERRIDE/OVERRIDING
        //LÀ HIỆN TƯỢNG CHỈ XẢY RA TRONG MỐI QUAN HỆ KẾ THỪA
        //VÀ INTERFACE, KHI "CON" CÓ HÀM TRÙNG TÊN 100% VỚI CHA


        //void FWrong(int a) { }  //FWrong(10)
        //void FWrong(int b) { }  //FWrong(10)
        //hai hàm đều yêu cầu đưa 1 con số int. Ko phân biệt đc 
        //hàm này với hàm kia do trùng kiểu dữ liệu đầu vào
        //ko care tên biến


        //pass by reference - truyền tham chiếu/con trỏ
        //trong hàm thay đổi, ngoài xa bị thay đổi theo
        static int SumIntegerList(out int sumEvenNums)
        {
            int sumAll = 0, sumEven = 0;

            for (int i = 1; i <= 10; i++)
            {
                sumAll += i;
                if (i % 2 == 0) //chia hết cho 2 là even
                    sumEven += i;
            }

            sumEvenNums = sumEven;
            //out là 1 lời cam kết, BẮT BUỘC BIẾN OUT TRONG HÀM
            //PHẢI ĐC GÁN GIÁ TRỊ NÀO ĐÓ THÌ MỚI KO BỊ BÁO LỖI
            //MUST HAVE, MANDATORY

            //return sumEven;
            return sumAll;
        }

        //Mantra: static chỉ chơi (trực tiếp) với static 

        static int SumIntegerList()
        {
            int sumAll = 0;

            for (int i = 1; i <= 10; i++)            
                sumAll += i;
            
            return sumAll;
        }

        //in ở trong tham số của hàm sẽ biến đổi biến thành READONLY
        //CÓ NGHĨA RẰNG TRONG HÀM CẤM THAY ĐỔI GIÁ TRỊ CỦA BIẾN
        //TODO AT HOME: ĐIỀU GÌ XẢY RA NẾU DÙNG IN VỚI BIẾN OBJECT
        //CheckReadOnlyParam(Student s)
        //{ trong hàm s được thay đổi theo kiểu nào!!!) }
        public static void CheckReadOnlyParam(in int n)
        {
            Console.WriteLine($"Before modifying, n is {n}");
            //n = 2024;
            int x = n;
            Console.WriteLine($"After modifying, n is {n}");
        }

        //Ctrl K C -> comment 1 nhóm code
        //Ctrl K U -> uncomment
        //Ctrl K D -> format lại code cho đẹp trai
        //SONARQUBE -> TOOL QUÉT CODE VÀ CHECK VAR SAI CONVENTION

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello, World!");

        //    double bmi = BmiCalculator.GetBmi(70, 1.7);
        //    string weightStatus = BmiCalculator.EvaluateWeightStatus(bmi);
        //    Console.WriteLine("Your weight status is: {0}", weightStatus);

        //    Console.WriteLine("Press any key to exit...");
        //    Console.ReadLine();
        //}

    }
}
