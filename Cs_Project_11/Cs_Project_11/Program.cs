using System;


namespace Cs_Project_11
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string str = "hello";
            char[] chArr = new char[] { 'w', 'o', 'r', 'l', 'd' };
            string str2 = new string(chArr);
            string str3 = new string(chArr, 2, 3);
            string str4 = new string('w', 4);
            Console.WriteLine(str);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine(str4);
            Console.WriteLine(str + str2);


            //string str = "Hello World!";
            
            //Console.WriteLine(str);
            
            //C# 자료형

            //int num1 = 10;
            //int num2 = 20;
            //Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);

            //char ch = 'B';
            //Console.WriteLine("char형의 크기 : " + sizeof(char));
            //Console.WriteLine("char 변수 ch의 값 :" + ch);
        }
    }
}