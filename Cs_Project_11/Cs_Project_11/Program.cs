using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Student
{
    private string m_name;
    public static string m_schoolName;
    public string NAME { get { return m_name; } set { m_name = value; } }
    public void Intro()
    {
        Console.WriteLine("{0}에 다니는 {1}입니다.", m_schoolName, m_name);
    }
}


namespace Cs_Project_11
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //C# 클래스

            Student.m_schoolName = "서울대학교";
            Student std1 = new Student();
            Student std2 = new Student();
            std1.NAME = "홍길동";
            std2.NAME = "아무개";
            std1.Intro();
            std2.Intro();


            //Hero 클래스 연습

            //Hero myhero = new Hero();
            //myhero.Damage(120);
            //Console.WriteLine("현재 hp : " + myhero.Gethp());

            //C# 자료형

            //object의 사용

            //object obj1 = 20;
            //object obj2 = 20;

            //int num1 = 10;
            //int num2 = 10;
            //if (obj1 == obj2)
            //    Console.WriteLine("object obj1과 obj2는 같습니다.");
            //else
            //    Console.WriteLine("object obj1과 obj2는 같지 않습니다.");
            //if (num1 == num2)
            //    Console.WriteLine("object num1과 num2는 같습니다.");
            //else
            //    Console.WriteLine("object num1과 num2는 같지 않습니다.");


            //int num = 10;
            //Object o = num; //Boxing
            //o = 1234;
            //num = (int)o; //UnBoxing
            //Console.WriteLine("Object o 의 값 : {0} int a 의 값 : {1}", o, num);


            //string의 사용

            //int result = 0;
            //bool isTry = false;
            //do
            //{
            //    isTry = false;
            //    try
            //    {
            //        result = int.Parse(Console.ReadLine());
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //} while (isTry);

            //Console.WriteLine("변환된 값 {0}", result);

            //int num;
            //string strnum = "456";
            //num = int.Parse(strnum);
            //Console.WriteLine("변환한 숫자 : {0}", num);
            //num = int.Parse(Console.ReadLine());
            //Console.WriteLine("입력한 숫자 : {0}", num);


            //string str = "     world";
            //string str2 = "HELLO";
            //Console.WriteLine(str.Insert(1, "Hello")); //부분 문자열 삽입
            ////문자열 길이가 최소 10이 될 수 있게 앞쪽에 공백 추가
            //Console.WriteLine(str.PadLeft(10));
            ////문자열 길이가 최소 10이 될 수 있게 앞쪽에 '*' 추가
            //Console.WriteLine(str.PadLeft(10, '*'));
            ////문자열 길이가 최소 10이 될 수 있게 뒤쪽에 공백 추가
            //Console.WriteLine(str.PadRight(10));
            ////문자열 길이가 최소 10이 될 수 있게 뒤쪽에 '*' 추가
            //Console.WriteLine(str.PadRight(10, '*'));
            //Console.WriteLine(str.Remove(4));
            //Console.WriteLine(str.Remove(4, 2));
            //Console.WriteLine(str.ToUpper());
            //Console.WriteLine(str2.ToLower());
            //Console.WriteLine(str.Trim());

            //for(int i =  0; i < 1000; i++)
            //{
            //    Console.WriteLine(string.Format("monster_data_{0:0000}", i + 1));
            //}
            //string str = string.Format("이름:{0} 나이:{1}", "유준헌", 17);
            //Console.WriteLine(str);

            //string str = "hello";
            //char[] chArr = new char[] { 'w', 'o', 'r', 'l', 'd' };
            //string str2 = new string(chArr);
            //string str3 = new string(chArr, 2, 3);
            //string str4 = new string('w', 4);
            //Console.WriteLine(str);
            //Console.WriteLine(str2);
            //Console.WriteLine(str3);
            //Console.WriteLine(str4);
            //Console.WriteLine(str + str2);


            //string str = "Hello World!";

            //Console.WriteLine(str);


            //int num1 = 10;
            //int num2 = 20;
            //Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);

            //char ch = 'B';
            //Console.WriteLine("char형의 크기 : " + sizeof(char));
            //Console.WriteLine("char 변수 ch의 값 :" + ch);
        }
    }
}

//Hero 클래스 연습
//class Hero
//{
//    private const int MAX_HP = 500;
//    public int hp = 0;
//    public int Gethp() { return hp; }
//    public Hero()
//    {
//        hp = MAX_HP;
//    }
//    public void LevelUP()
//    {
//        hp = MAX_HP;
//    }
//    public void Damage(int dmg)
//    {
//        if (hp - dmg > 0) hp -= dmg;
//        else { hp = 0; }
//    }
//}

//namespace Test
//{
//    struct Point
//    {
//        public int hp;
//        public int mp;
//    }
//}