using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int TestDelegate(int a, int b);
class Calculator
{
    public int Plus(int a, int b) { return a + b; }
    public int Minus(int a, int b) { return a - b; }
    public int Multuply(int a, int b) { return a * b; }
}


namespace Cs_Project_11
{
    class Program
    {
        public static void Calculator(int a, int b, TestDelegate callback)
        {
            Console.WriteLine(callback(a, b));
        }

        static void Main()
        {
            Calculator cal = new Calculator();

            Calculator(10, 20, cal.Plus);
            Calculator(10, 20, cal.Minus);
            Calculator(10, 20, cal.Multuply);

        }
        //static void Print<T>(T value)
        //{
        //    Console.WriteLine(value);
        //}

        //static void CopyArray<T>(T[] src,T[] dest)
        //{
        //    src.CopyTo(dest, 0);
        //}
        //static void Main()
        //{
        //    int[] srcInt = { 1, 2, 3, 4, 5 };
        //    int[] tagInt = new int[srcInt.Length];
        //    string[] srcStr = { "hello", "sbs", "game", "academy" };
        //    string[] tagStr = new string[srcStr.Length];
        //    CopyArray<int>(srcInt, tagInt);
        //    CopyArray<string>(srcStr, tagStr);
        //    for (int i = 0; i < srcInt.Length; i++) Print(tagInt[i]);
        //    for (int i = 0; i < srcStr.Length; i++) Print(tagStr[i]);
        //}
        //static void Main()
        //{
        //    List<int> list1 = new List<int>();
        //    List<float> list2 = new List<float>();
        //    List<string> list3 = new List<string>();
        //    list1.InitArray(0, 58);
        //    list1.InitArray(1, 30);
        //    list2.InitArray(0, 75.2f);
        //    list2.InitArray(1, 65.5f);
        //    list3.InitArray(0, "아무개");
        //    list3.InitArray(1, "홍길동");
        //    for (int i = 0; i < list1.Length; i++)
        //    {
        //        Print("이름 : " + list3.GetValue(i));
        //        Print("나이 : " + list1.GetValue(i));
        //        Print("몸무게 : "  + list2.GetValue(i));
        //    }

        //}
        //static void Print<T>(T value)
        //{
        //    Console.WriteLine(value);
        //}
        //static void Main()
        //{
        //    string name = "유준헌";
        //    int age = 17;
        //    float height = 176.0f;
        //    double weight = 56.0d;
        //    Print<string>(name);
        //    Print<int>(age);
        //    Print<float>(height);
        //    Print<double>(weight);
        //}

        //static void Main(string[] args)
        //{


            //int[] orgArr = new int[] { 10, 20, 30, 40 };
            //int[] copyArr = (int[])orgArr.Clone();
            //for(int i = 0; i < copyArr.Length; i++)
            //{
            //    Console.WriteLine("copyArr[{0}] = {1}", i, copyArr[i]);
            //}

            //int[] orgArr = new int[] { -1, -3, -5, -7, -9 };
            //int[] copyArr = { 2, 4, 6, 8, 10 };
            //Array.Copy(orgArr, 0, copyArr, 2, 3);
            //for (int i = 0; i < copyArr.Length; i++)
            //{
            //    Console.WriteLine("copyArr[{0}] = {1}", i, copyArr[i]);
            //}
        //}


        //static void Main(string[] args)
        //{


        //PoketMon[] pomon = new PoketMon[4];
        //pomon[0] = new PoketMon("노말", "잠만보");
        //pomon[1] = new PoketMon("불꽃", "파이리");
        //pomon[2] = new PoketMon("전기", "피카츄");
        //pomon[3] = new PoketMon("물", "꼬부기");
        //foreach (PoketMon po in pomon)
        //{
        //    po.PrintPoketMon();
        //}
        //string[][] jagged_str = new string[3][]
        //{
        //    new string[3] {"SBS","Game","Academy"},
        //    new string[2] {"강남역", "12번출구로"},
        //    new string[] {"나오시면","금방", "찾으실","수","있습니다." }
        //};
        //foreach (string[] jagged in jagged_str)
        //{
        //    foreach (string str_element in jagged)
        //    {
        //        Console.Write(str_element + " ");
        //    }
        //    Console.WriteLine();
        //}
        //int i = 0;
        //int[,] array = new int[2, 3]
        //{
        //    {1,2,3 },
        //    {4,5,6 }
        //};
        //foreach (int num in array)
        //{
        //    Console.Write(num + " ");
        //    i++;
        //    if (i % array.GetLength(1) == 0)
        //        Console.WriteLine();
        //}
        //int[] array1 = new int[5];
        //int[] array2 = new int[] { 1, 3, 5, 7, 9 };
        //int[] array3 = { 1, 2, 3, 4, 5, 6 };
        //int[,] multiDimensionalArray1 = new int[2, 3];
        //int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };
        //int[][] jaggedArray = new int[2][];
        //jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
        //jaggedArray[1] = new int[3] { 5, 6, 7 };

        //}
        //static void Main(string[] args)
        //{
        //    TempRecord tempRecord = new TempRecord();
        //    tempRecord[3] = 56.3F;
        //    tempRecord[5] = 60.1F;
        //    for (int i = 0; i < tempRecord.Length; i++)
        //        System.Console.WriteLine("tempRecord[{0}] = {1}", i, tempRecord[i]);
        //    System.Console.ReadKey();
        //}
        //static void Main(string[] args)
        //{
        //int i = 0;
        //int[] arr = new int[5] { 10, 20, 30, 40, 50 };

        //foreach(int n in arr)
        //{
        //    Console.WriteLine("arr[{0}] : {1}", i, n);
        //    i++;
        //}

        //string str = "Hello World\n";
        //foreach(char c in str)
        //{
        //    Console.Write(c);
        //}

        //int num1 = 10;
        //int num2 = 20;

        //Swap(ref num1, ref num2);

        //int num = 10;
        //Console.WriteLine("현재 값 : {0}", num);
        //Increment(ref num);
        //Console.WriteLine("증가 후 값 : {0}", num);


        //Student.m_schoolName = "서울대학교";
        //Student std1 = new Student();
        //Student std2 = new Student();
        //std1.NAME = "홍길동";
        //std2.NAME = "아무개";
        //std1.Intro();
        //std2.Intro();


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

        //static void Increment(ref int num)
        //{
        //    num++;
        //}
        //static void Swap(ref int a, ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}
        //}
    }
}
//C# 일반화
//class List<T>
//{
//    private T[] arr;
//    public List() { arr = new T[2]; }
//    public int Length { get { return arr.Length; } }
//    public void InitArray(int index, T value) { arr[index] = value; }
//    public T GetValue(int index) { return arr[index]; }
//}

//C# 배열

//class ArrayClass2D
//{
//    static void PrintArray(int[,] arr)
//    {
//        for (int i =0; i < arr.GetLength(0); i++)
//        {
//            for (int j = 0; j < arr.GetLength(1); j++)
//            {
//                System.Console.WriteLine("arr[{0},{1}] = {2}", i, j, arr[i, j]);
//            }
//        }
//    }
//    static void Main()
//    {
//        PrintArray(new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } });

//        Console.WriteLine("Press any key to exit.");
//        Console.ReadKey();
//    }
//}

//class ArrayClass
//{
//    static void PrintArray(string[] arr)
//    {
//        for (int i = 0; i < arr.Length; i++)
//        {
//            System.Console.Write(arr[i] + "{0}", i < arr.Length - 1 ? " " : " ");

//        }
//        System.Console.WriteLine();
//    }
//    static void Main()
//    {
//        string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
//        PrintArray(weekDays);
//    }
//}

//class PoketMon
//{
//    private string kind;
//    private string name;
//    public PoketMon(string kind, string name)
//    {
//        this.kind = kind;
//        this.name = name;
//    }
//    public void PrintPoketMon()
//    {
//        Console.WriteLine("종류 : {0} / 이름 : {1}", kind, name);
//    }
//}

//class DayCollection
//{
//    string[] days = { "Sun", "Mon", "Tue", "Wed", "Thurs", "Fri", "Sat" };

//    private int GetDay(string testDay)
//    {
//        for (int j = 0; j < days.Length - 1; j++)
//        {
//            if (days[j] == testDay)
//            {
//                return j;
//            }
//        }
//        throw new System.ArgumentOutOfRangeException(testDay, "testDay must be in the form \"Sun\", \"Mon\", etc");
//    }
//    public int this[string day]
//    {
//        get
//        {
//            return (GetDay(day));
//        }
//    }
//}

//class TempRecord
//{
//    private float[] temps = new float[10] { 56.2F, 56.7F, 56.5F, 56.9F, 58.8F,
//                                            61.3F, 65.9F,62.1F, 59.2F, 57.5F };
//    public int Length { get { return temps.Length; } }
//    public float this[int index]
//    {
//        get
//        {
//            return temps[index];
//        }
//        set
//        {
//            temps[index] = value;
//        }
//    }
//}

//클래스 연습
//class Student
//{
//    private string m_name;
//    public static string m_schoolName;
//    public string NAME { get { return m_name; } set { m_name = value; } }
//    public void Intro()
//    {
//        Console.WriteLine("{0}에 다니는 {1}입니다.", m_schoolName, m_name);
//    }
//}

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