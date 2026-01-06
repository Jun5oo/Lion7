using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////사용자 입력 
            //Console.Write("이름을 입력해주세요: ");
            //string userName = Console.ReadLine();
            //Console.WriteLine($"안녕하세요 {userName}");            

            //Console.Write("나이를 입력해주세요: ");
            //string age_input = Console.ReadLine();
            //int input = int.Parse(age_input);
            //Console.WriteLine($"나이: {input + 1}");

            //이진수를 정수로 변환 
            //Console.Write("2진수를 입력하세요: "); 
            //string binaryInput = Console.ReadLine();
            //int decimalValue = Convert.ToInt32(binaryInput, 2);

            //Console.WriteLine($"입력한 이진수: {binaryInput}");
            //Console.WriteLine($"십진수로 변환: {decimalValue}");

            //string binary = Convert.ToString(decimalValue, 2); 

            //Console.WriteLine($"다시 이진수로 변환: {binary}");

            //Console.WriteLine("=== 캐릭터 생성 ===");
            //Console.Write("캐릭터 이름을 입력하세요: "); 
            //string name = Console.ReadLine();

            //Console.WriteLine($"환영합니다. {name}님!");
            //Console.Write("시작 레벨을 입력하세요: ");
            //string str_age = Console.ReadLine();
            //Console.WriteLine($"{name}님의 시작 레벨은 {int.Parse(str_age)}입니다"); 

            //var를 사용하여 변수 선언 
            //var name = "Alice";
            //var age = 25;
            //var isStudent = true;

            //Console.WriteLine($"이름: {name}");
            //Console.WriteLine($"나이: {age}");
            //Console.WriteLine($"학생여부: {isStudent}"); 

            //default: 키워드를 사용한 기본값 설정 
            //int defaultInt = default;
            //string defaultString = default;
            //string defaultBool = default; 

            //int smallNumber = 100;
            //long bigNumber = smallNumber;
            //double doubleNumber = smallNumber;

            //Console.WriteLine("=== 암시적 변환 ===");
            //Console.WriteLine($"{bigNumber}과 {doubleNumber}");
            //Console.WriteLine($"{bigNumber.GetType()}, {doubleNumber.GetType()}");

            //Console.WriteLine("=== 명시적 변환 ===");
            //double pi = 3.14159;
            //int intPi = (int)pi;

            //Console.WriteLine($"int로 변환 {intPi}");

            //문자열을 숫자로 변환 
            //string str_score = "95"; 
            //int score = int.Parse(str_score);

            //string double_score = "95.5"; 
            //double d_score = double.Parse(double_score);

            //Console.WriteLine(score);
            //Console.WriteLine(d_score);

            int num = 9;
            string str_num = num.ToString(); 
            Console.WriteLine(str_num); 
        }
    }
}
