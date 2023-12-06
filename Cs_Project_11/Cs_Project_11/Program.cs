using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;



namespace Cs_Project_11
{
    class Program
    {


        //public static void Main()
        //{
        //    StringBuilder sb = new StringBuilder("안녕하세요!");
        //    Console.WriteLine(sb);
        //    sb.Append(" SBS 게임 아카데미 입니다.");
        //    Console.WriteLine("Append() : {0}", sb);
        //    sb.AppendFormat(" 제 이름은 {0}이고 나이는 {1}살 입니다.", "유준헌", 17);
        //    Console.WriteLine("AppendFormat() : {0}", sb);
        //    sb.Remove(0, 6);
        //    Console.WriteLine("Remove() : {0} ", sb);
        //    sb.Insert(12, "강남지점");
        //    Console.WriteLine("Insert() : {0}", sb);
        //    sb.Replace("강남지점", "신촌지점");
        //    Console.WriteLine("Replace() : {0}", sb);
        //    sb.Clear();
        //    Console.WriteLine("Clear() : {0}", sb);
        //}
        //static void Main(string[] args)
        //{
        //    Stage stage = new Stage();
        //    stage.CreateMonsters();
        //    MonsterManager.Instance.DrawMonstersInfo();
        //    Console.WriteLine("Stage Clear : {0} ", stage.IsClear());
        //}
        //static void Main()
        //{
        //    Singleton.Instance.DrawMessage();
        //}
        

        //public static void Main()
        //{
        //    Action<string> Print = (str) => Console.WriteLine(str);
        //    Action<int, int> Add = (a, b) => Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        //    Action<int, int> Mul = (a, b) => Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        //    Action<double> FtoC = (F) => Console.WriteLine("화씨 {0} -> 섭씨 {1}", F, (F - 32) * 5 / 9);
        //    Action<double> CtoF = (C) => Console.WriteLine("썹씨 {0} -> 화씨 {1}",C, (C * 9 / 5) + 32);

        //    Print("안녕하세요 SBS 게임 아카데미입니다.");
        //    Add(10, 20);
        //    Mul(10, 20);
        //    FtoC(132.2d);
        //    CtoF(36.5d);
        //}

        //public static void Main()
        //{
        //    Func<string> Print = () => "안녕하세요 SBS 게임 아카데미 입니다.";
        //    Func<int, int, int> Add = (a, b) => a + b;
        //    Func<int, int, int> Mul = (a, b) => a * b;
        //    Func<double, double> FtoC = (F) => (F - 32) * 5 / 9;
        //    Func<double, double> CtoF = (C) => (C * 9 / 5) + 32;

        //    Console.WriteLine("Func Print값 : {0}", Print());
        //    Console.WriteLine("Func Add 값 : {0}",Add(10,20));
        //    Console.WriteLine("Func Mul 값 : {0}",Mul(10,20));
        //    Console.WriteLine("Func FtoC 값 : {0}",FtoC(132.2d));
        //    Console.WriteLine("Func CtoF 값 : {0}",CtoF(36.5));

        //}


        //public static string UpperCaseString(string inputString)
        //{
        //    return inputString.ToUpper();
        //}
        //public static string DrawMessage()
        //{
        //    return "안녕하세요 SBS 게임 아카데미 입니다.";
        //}
        //public static void Main()
        //{
        //    Func<string, string> func01 = UpperCaseString;
        //    Func<string> func02 = DrawMessage;
        //    string name = "Yu Jun Heon";
        //    Console.WriteLine(func01(name));
        //    Console.WriteLine(func02());
        //}


        //static void GetFiles()
        //{
        //    string path = @"C:\Users\SBSGAME\Desktop\yujunheon\Cs_Project_11\Cs_Project_11\";
        //    DirectoryInfo dinfo = new DirectoryInfo(path);
        //        if (dinfo.Exists)
        //        {
        //            string[] exts = new string[] { ".bmp", ".txt", ".gif" };
        //            FileInfo[] files = dinfo.GetFiles("*.*", SearchOption.TopDirectoryOnly);
        //            string[] filestr = new string[files.Length];
        //            for (int i = 0; i < files.Length; i++)
        //                filestr[i] = files[i].ToString();
        //            string[] result = filestr.Where(
        //                (s) => exts.Contains(Path.GetExtension(s), StringComparer.OrdinalIgnoreCase)).ToArray();
        //            for (int i = 0; i < result.Length; i++)
        //                Console.WriteLine(result[i]);
        //        }
        //}
        //public static void Main()
        //{
        //    GetFiles();
        //}
        


        //delegate void MyDelegate(int a, int b);
        //public static void Main()
        //{
        //    MyDelegate Compare = (a, b) =>
        //    {
        //        if (a > b)
        //            Console.WriteLine("{0} > {1}", a, b);
        //        else if (a < b)
        //            Console.WriteLine("{0} < {1}", a, b);
        //        else
        //            Console.WriteLine("{0} == {1}", a, b);
        //    };
        //    Compare(30, 60);
        //    Compare(60, 30);
        //    Compare(100, 100);
        //}
        //delegate int MyDelegate(int a, int b);
        //delegate void PrintDelegate();
        //public static void Main()
        //{
        //    MyDelegate Add = (a, b) => a + b;
        //    MyDelegate Multi = (a, b) => a * b;
        //    PrintDelegate Message = () => Console.WriteLine("안녕하세요 람다식을 배워볼까요?");
        //    Console.WriteLine(Add(100, 200));
        //    Console.WriteLine(Multi(20, 50));
        //    Message();
        //}

        // 파일 입출력

        //[Serializable]
        //class student
        //{
        //    public int num { get; set; }
        //    public string name { get; set; }
        //}
        //private static void FileCreate(string filename)
        //{
        //    string path = @"C:\Users\SBSGAME\Desktop\yujunheon\Cs_Project_11\Cs_Project_11\" + filename;
        //    student me = new student() { num = 1, name = "준헌" };
        //    FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
        //    BinaryFormatter bf = new BinaryFormatter();
        //    bf.Serialize(file, me);
        //    file.Close();
        //    file = new FileStream(path, FileMode.Open, FileAccess.Read);
        //    var result = (student)bf.Deserialize(file);
        //    file.Close();
        //    Console.WriteLine("번호 {0}, 이름 {1}", result.num, result.name);

        //}
        //static void Main()
        //{
        //    Console.WriteLine("생성할 파일 이름을 입력해 주세요");
        //    string filename = Console.ReadLine();
        //    FileCreate(filename); 
        //}


        //private static void FileCreate(string filename)
        //{
        //    string path = @"C:\Users\SBSGAME\Desktop\yujunheon\Cs_Project_11\Cs_Project_11\" + filename;
        //    FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
        //    BinaryWriter bw = new BinaryWriter(file);
        //    bw.Write(int.MaxValue);
        //    bw.Write(double.MaxValue);
        //    bw.Write("안녕하세요 SBS 게임 아카데미 입니다.");
        //    file.Close();
        //    file = new FileStream(path, FileMode.Open, FileAccess.Read);
        //    BinaryReader br = new BinaryReader(file);
        //    Console.WriteLine("File Size : {0} bytes", br.BaseStream.Length);
        //    Console.WriteLine(br.ReadInt32());
        //    Console.WriteLine(br.ReadDouble());
        //    Console.WriteLine(br.ReadString());
        //    file.Close();
        //}
        //static void Main()
        //{
        //    Console.WriteLine("생성할 파일 이름을 입력해주세요");
        //    string filename = Console.ReadLine();
        //    FileCreate(filename);
        //}


        //public static byte[] WriteStringBytes(string str, FileStream fs)
        //{
        //    byte[] bytestr = new UTF8Encoding(true).GetBytes(str);
        //    fs.Write(bytestr, 0, bytestr.Length);
        //    return bytestr;
        //}
        //private static void FileRead(string filename)
        //{
        //    string path = @"C:\Users\SBSGAME\Desktop\yujunheon\Cs_Project_11\Cs_Project_11\" + filename;
        //    string outstr = "안녕하세요 SBS 게임 아카데미 입니다.";
        //    byte[] readbyte = new byte[1024];
        //    FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        //    WriteStringBytes(outstr, file);
        //    file.Seek(0, SeekOrigin.Begin);
        //    UTF8Encoding utf8 = new UTF8Encoding(true);
        //    file.Read(readbyte, 0, readbyte.Length);
        //    Console.WriteLine(utf8.GetString(readbyte));
        //    file.Close();
        //}
        //static void Main()
        //{
        //    Console.WriteLine("파일 이름을 입력해 주세요");
        //    string filename = Console.ReadLine();
        //    FileRead(filename);
        //}



        //private static void FileWrite(string filename, string text)
        //{
        //    string path = @"C:\Users\SBSGAME\Desktop\yujunheon\Cs_Project_11\Cs_Project_11\" + filename;
        //    FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
        //    StreamWriter sw = new StreamWriter(fs);
        //    sw.WriteLine(text);
        //    sw.Close();
        //    Console.WriteLine("저장 완료");
        //}
        //static void Main()
        //{
        //    Console.WriteLine("저장 할 파일 이름을 입력해 주세요");
        //    string filename = Console.ReadLine();
        //    FileWrite(filename, "안녕하세요 SBS 게임 아카데미 입니다.");
        //}

        //private static void FileRead(string filename)
        //{ 
        //    string path = @"C:\Users\SBSGAME\Desktop\yujunheon\Cs_Project_11\Cs_Project_11\" + filename;
        //    FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
        //    StreamReader sr = new StreamReader(file);
        //    string readText = sr.ReadToEnd();
        //    sr.Close();
        //    file.Close();
        //    Console.WriteLine(readText);
        //}
        //static void Main()
        //{
        //    Console.WriteLine("읽어올 파일 이름을 입력해주세요");
        //    string filename = Console.ReadLine();
        //    FileRead(filename);
        //}

        //private static void FileRead(string filename)
        //{
        //    string path = @"C:\Users\SBSGAME\Desktop\yujunheon\Cs_Project_11\Cs_Project_11\" + filename;
        //    TextReader tr = new StreamReader(path);
        //    string readText = tr.ReadToEnd();
        //    tr.Close();
        //    Console.WriteLine(readText);
        //}
        //static void Main()
        //{
        //    Console.WriteLine("읽어올 파일 이름을 입력해주세요");
        //    string filename = Console.ReadLine();
        //    FileRead(filename);
        //}


        //void CastingTest(object obj)
        //{
        //    BaseC baseC;
        //    bool already = obj is BaseC;
        //    if(already)
        //    {
        //        baseC = obj as BaseC;
        //        if (baseC != null)
        //            baseC.PrintMethod();
        //    }
        //    BaseC baseC2 = (BaseC)obj;
        //    baseC2.PrintMethod();
        //}
        //static void Main(string[] args)
        //{
        //    DerivedC derivedC = new DerivedC();
        //    new Program().CastingTest(derivedC);
        //    derivedC.PrintMethod();
        //    derivedC.PrintMethod2();
        //}
        //static void PrintPoint(Ipoint p)
        //{
        //    Console.WriteLine("x={0}, y={1}", p.x, p.y);
        //}
        //static void Main()
        //{
        //    Point p = new Point(2, 3);
        //    Console.WriteLine("현재 좌표는 : ");
        //    PrintPoint(p);
        //}
        //static void Main()
        //{
        //    Car mycar = new Car();
        //    mycar.Gear(3);
        //    mycar.Volume(5);
        //    CarControl carCon = mycar;
        //    AudioControl audioCon = mycar;
        //    carCon.Off();
        //    audioCon.Off();
        //}

        //static void Main()
        //{
        //    MultiInheritance mi = new MultiInheritance();
        //    interA interface1 = mi;
        //    interB interface2 = mi;
        //    interC interface3 = mi;
        //    interface1.a();
        //    interface2.b();
        //    interface3.c();
        //    mi.a();
        //    mi.b();
        //    mi.c();
        //}
        //static void Main()
        //{
        //    Bird bird = new Bird();
        //    Cat cat = new Cat();
        //    Dog dog = new Dog();
        //    bird.Bark();
        //    cat.Bark();
        //    dog.Bark();
        //    List<Animal> listAni = new List<Animal>() { new Bird(), new Cat(), new Dog() };
        //    for (int i = 0; i < listAni.Count; i++)
        //        listAni[i].Attack();
        //}

        //static void Main()
        //{
        //    General gn = new General();
        //    Console.WriteLine("프로퍼티 X의 값 : " + gn.X);
        //    gn.func();
        //    gn.func2();
        //}


        //C# 컬렉션
        //public static void Main()
        //{
        //    Stage stage = new Stage();
        //    stage.Start();
        //    stage.DrawMonster();
        //}
        //static void Main()
        //{


        //Animal ani = new Animal();
        //Cat cat = new Cat();
        //Dog dog = new Dog();
        //ani.Bark();
        //cat.Bark();
        //dog.Bark();
        //List<Animal> listAni = new List<Animal>() { new Animal(), new Cat(), new Dog() };
        //for (int i = 0; i < listAni.Count; i++)
        //    listAni[i].Attack();


        //Character[] characters = new Character[2];

        //characters[0] = new Knight();
        //characters[1] = new Archer();

        //for (int i = 0; i < characters.Length; i++)
        //{
        //    Console.WriteLine(characters[i].ToString());
        //    characters[i].ReadyToBattle();
        //}


        //double r = 3.0, h = 5.0;
        //Shape c = new Circle(r);
        //Shape s = new Circle(r);
        //Hashtable ht = new Hashtable();
        //if (!ht.ContainsKey("오렌지"))
        //    ht.Add("오렌지", "Orange");
        //if (!ht.ContainsKey("바나나"))
        //    ht.Add("바나나", "Banana");
        //if (!ht.ContainsKey("사과"))
        //    ht.Add("사과", "Apple");
        //foreach(string s in ht.Keys)
        //{
        //    Console.WriteLine(s);
        //    Console.WriteLine(ht[s]);
        //}
        //Console.WriteLine(ht["오렌지"]);
        //Console.WriteLine(ht["바나나"]);
        //Console.WriteLine(ht["사과"]);
        //Queue que = new Queue();
        //que.Enqueue(10);
        //que.Enqueue(20);
        //que.Enqueue(30);
        //que.Dequeue();
        //que.Enqueue(4.4);
        //que.Dequeue();
        //que.Enqueue("ABC");
        //while(que.Count > 0)
        //{
        //    Console.WriteLine(que.Dequeue());
        //}
        //ArrayList list = new ArrayList();
        //list.Add(10);
        //list.Add(20);
        //list.Add(30);
        //list.RemoveAt(1);
        //list.Insert(1, 36.5f);
        //list.Add("SBS 게임 아카데미");
        //for(int i = 0; i < list.Count; i++)
        //{
        //    Console.WriteLine(list[i]);
        //}
        //}
        //public static void Calculator<T>(T a, T b, TestDelegate<T> callback)
        //{
        //    Console.WriteLine(callback(a, b));
        //}
        //static void Main()
        //{
        //    Calculator cal = new Calculator();

        //    Calculator(10, 20, cal.Plus);
        //    Calculator(54.6f, 96.32f, cal.Plus);
        //    Calculator(200.5f, 120.10f, cal.Minus);
        //    Calculator(36.5f, 42.3f, cal.Multiply);
        //}
        //static void Main()
        //{
        //    Calculator cal = new Calculator();
        //    TestDelegate del = cal.Plus;
        //    del += cal.Minus;
        //    del += cal.Multiply;
        //    del(10, 20);
        //    del -= cal.Plus;
        //    del -= cal.Minus;
        //    del(20, 30);
        //}


        //public static void Calculator(int a, int b, TestDelegate callback)
        //{
        //    Console.WriteLine(callback(a, b));
        //}

        //static void Main()
        //{
        //    Calculator cal = new Calculator();

        //    Calculator(10, 20, cal.Plus);
        //    Calculator(10, 20, cal.Minus);
        //    Calculator(10, 20, cal.Multuply);

        //}
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

//public class Stage
//{
//    const int MONSTER_MAX = 10;
//    public void CreateMonsters()
//    {
//        for (int i = 0; i < MONSTER_MAX; i++)
//        {
//            MonsterManager.Instance.Add(new Monster());
//        }
//        MonsterManager.Instance.InitMonsters();
//    }
//    public bool IsClear()
//    {
//        for (int i = 0; i < MonsterManager.Instance.Count; i++)
//        {
//            Monster mon = null;
//            if ((mon = MonsterManager.Instance.GetMonster(i)) != null)
//            {
//                if (mon.m_isAlive) return false;
//            }
//        }
//        return true;
//    }
//}

//namespace ConsoleApplication12
//{
//    public class Polygon
//    {
//        public virtual int area(int a) { return 0; }
//        public virtual int perimeter(int a) { return 0; }
//    }
//    public class Square : Polygon
//    {
//        public override int area(int a)
//        {
//            return a * a;
//        }
//        public override int perimeter(int a)
//        {
//            return 4 * a;
//        }
//    }
//    public class Triangle : Polygon
//    {
//        public override int area(int a)
//        {
//            return a * a / 2;
//        }
//        public override int perimeter(int a)
//        {
//            return 3 * a;
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Polygon sq = new Square();
//            Polygon tri = new Triangle();
//            Console.WriteLine("area:{0} , perimeter:{1}", sq.area(2), sq.perimeter(4));
//            Console.WriteLine("area:{0} , perimeter:{1}", tri.area(3), tri.perimeter(5));        
//        }
//    }
//}

//class BaseC
//{
//    public virtual void PrintMethod()
//    {
//        Console.WriteLine("부모 클래스 Method");
//    }
//}
//class DerivedC : BaseC
//{
//    public override void PrintMethod()
//    {
//        Console.WriteLine("부모 Method 재정의!!");
//    }
//    public void PrintMethod2()
//    {
//        Console.WriteLine("자식 클래스 Method");
//    }
//}

//interface Ipoint
//{
//    int x { get; set; }
//    int y { get; set; }
//}
//class Point : Ipoint
//{
//    private int _x;
//    private int _y;
//    public Point(int x, int y)
//    {
//        _x = x;
//        _y = y;
//    }
//    public int x { get { return _x; } set { _x = value; } }
//    public int y { get { return _y; } set { _y = value; } }
//}

//interface CarControl
//{
//    void Gear(int i);
//    void Off();
//}
//interface AudioControl
//{
//    void Volume(int i);
//    void Off();
//}
//public class Car : CarControl, AudioControl
//{
//    public void Gear(int i)
//    {
//        Console.WriteLine("현재 기어는 {0} 입니다.", i);
//    }
//    public void Volume(int i)
//    {
//        Console.WriteLine("현재 볼륨은 {0} 입니다.", i);
//    }
//    void CarControl.Off()
//    {
//        Console.WriteLine("시동을 껐습니다.");
//    }
//    void AudioControl.Off()
//    {
//        Console.WriteLine("오디오 전원을 끕니다.");
//    }
//}

//interface interA
//{
//    void a();
//}
//interface interB
//{
//    void b();
//}
//interface interC : interA
//{
//    void c();
//}
//class MultiInheritance : interB , interC
//{
//    public void a() { Console.WriteLine("a 메소드 호출"); }
//    public void b() { Console.WriteLine("b 메소드 호출"); }
//    public void c() { Console.WriteLine("c 메소드 호출"); }
//}

//abstract class Animal
//{
//    public abstract void Bark();
//    public abstract void Attack();
//}
//class Cat : Animal
//{
//    public Cat() { Console.WriteLine("나는 고양이 입니다."); }
//    public override void Bark() { Console.WriteLine("냐옹"); }
//    public override void Attack() { Console.WriteLine("핡퀴기 공격"); }
//}

//class Dog : Animal
//{
//    public Dog() { Console.WriteLine("나는 개 입니다."); }
//    public override void Bark() { Console.WriteLine("멍멍"); }
//    public override void Attack() { Console.WriteLine("물기 공격"); }
//}

//class Bird : Animal
//{
//    public Bird() { Console.WriteLine("나는 새 입니다."); }
//    public override void Bark() { Console.WriteLine("짹짹"); }
//    public override void Attack() { Console.WriteLine("쪼기 공격"); }
//}

//abstract class Abstract
//{
//    protected int x = 10;
//    public abstract int X { get; set; }
//    public virtual void func() { Console.WriteLine("가상 클래스 선언"); }
//    public void func2() { Console.WriteLine("일반 메소드 호출"); }
//}
//class General : Abstract
//{
//    public override int X
//    {
//        get { return x + 20; }
//        set { x = value; }
//    }
//    public override void func()
//    {
//        base.func();
//        Console.WriteLine("가상 클래스 구현");
//    }
//}

//class Animal
//{
//    public Animal() { Console.WriteLine("나는 동물입니다."); }
//    public virtual void Bark() { Console.WriteLine("울음 소리를 냅니다."); }
//    public virtual void Attack() { Console.WriteLine("공격을 시작합니다."); }
//}

//class Cat:Animal
//{
//    public Cat() { Console.WriteLine("나는 고양이 입니다."); }
//    public override void Bark() { Console.WriteLine("냐옹."); }
//    public override void Attack() { Console.WriteLine("핡퀴기 공격."); }
//}

//class Dog : Animal
//{
//    public Dog() { Console.WriteLine("나는 개 입니다."); }
//    public new void Bark() { Console.WriteLine("멍멍."); }
//    public new void Attack() { Console.WriteLine("물기기 공격."); }
//}

//public class Character
//{
//    public virtual void ReadyToBattle()
//    {
//        Console.WriteLine("전투 태세를 취합니다.");
//    }
//}

//public class Knight : Character
//{
//    public override void ReadyToBattle()
//    {
//        Console.WriteLine("기사 : 칼을 뽑아 전투 태세를 취합니다.");
//    }
//    public override string ToString()
//    {
//        return "기사 클래스";
//    }
//}
//public class Archer : Character
//{
//    public override void ReadyToBattle()
//    {
//        Console.WriteLine("궁수 : 활을 뽑아 전투 태세를 취합니다.");
//    }
//    public override string ToString()
//    {
//        return "궁수 클래스";
//    }
//}

//public class Shape
//{
//    public const double PI = Math.PI;
//    protected double x, y;
//    public Shape() { }
//    public Shape(double x, double y)
//    {
//        this.x = x;
//        this.y = y;
//    }
//    public virtual double Area()
//    {
//        return x * y;
//    }
//}
//public class Circle : Shape
//{
//    public Circle(double r) : base(r, 0) { }
//    public override double Area()
//    {
//        return PI * x * x;
//    }
//}
//class Sphere : Shape
//{
//    public Sphere(double r) : base(r, 0) { }
//    public override double Area()
//    {
//        return 4 * PI * x * x;
//    }
//}
//class Cylinder : Shape
//{
//    public Cylinder(double r, double h) : base(r, h) { }
//    public override double Area()
//    {
//        return 2 * PI * x * x + 2 * PI * x * y;
//    }
//}

//public static void TestDictionary()
//{
//    Dictionary<string, string> genDic = new Dictionary<string, string>();
//    genDic.Add("txt", "notepad.exe");
//    genDic.Add("bmp", "paint.exe");
//    genDic.Add("mp3", "wmplayer.exe");
//    Console.WriteLine("[Dictionary]");
//    foreach (KeyValuePair<string,string> kvp in genDic)
//    {
//        Console.WriteLine("Key = {0}, Value = {1}",
//            kvp.Key, kvp.Value);
//    }
//}
//static void Main()
//{
//    TestDictionary();
//}

//마이크로 소프트 예제
//namespace Bookstore
//{
//    public struct Book
//    {
//        public string Title;
//        public string Author;
//        public decimal Price;
//        public bool Paperback;

//        public Book(string title, string author, decimal price, bool paperback)
//        {
//            Title = title;
//            Author = author;
//            Price = price;
//            Paperback = paperback;
//        }
//    }


//    public delegate void ProcessBookDelegate(Book book);

//    public class BookDB
//    {
//        ArrayList list = new ArrayList();
//        public void AddBook(string title, string author, decimal price, bool paperback)
//        {
//            list.Add(new Book(title, author, price, paperback));
//        }
//        public void ProcessPaperbackBooks(ProcessBookDelegate processBook)
//        {
//            foreach (Book b in list)
//            {
//                if (b.Paperback)
//                    processBook(b);
//            }
//        }
//    }
//}

//namespace BookTestClient
//{
//    using Bookstore;
//    class PriceTotaller
//    {
//        int countBooks = 0;
//        decimal priceBooks = 0.0m;

//        internal void AddBookToTotal(Book book)
//        {
//            countBooks += 1;
//            priceBooks += book.Price;
//        }
//        internal decimal AveragePrice()
//        {
//            return priceBooks / countBooks;
//        }
//    }
//    class Test
//    {
//        static void PrintTitle(Book b)
//        {
//            Console.WriteLine($"   {b.Title}");
//        }
//        static void Main()
//        {
//            BookDB bookDB = new BookDB();
//            AddBooks(bookDB);
//            Console.WriteLine("Paperback Book Titles:");
//            bookDB.ProcessPaperbackBooks(PrintTitle);
//            PriceTotaller totaller = new PriceTotaller();
//            bookDB.ProcessPaperbackBooks(totaller.AddBookToTotal);
//            Console.WriteLine("Average Paperback Book Price: ${0:#.##}",
//            totaller.AveragePrice());
//        }
//        static void AddBooks(BookDB bookDB)
//        {
//            bookDB.AddBook("The C Programming Language", "Brian W. Kernighan and Dennis M. Ritchie", 19.95m, true);
//            bookDB.AddBook("The Unicode Standard 2.0", "The Unicode Consortium", 39.95m, true);
//            bookDB.AddBook("The MS-DOS Encyclopedia", "Ray Duncan", 129.95m, false);
//            bookDB.AddBook("Dogbert's Clues for the Clueless", "Scott Adams", 12.00m, true);
//        }
//    }
//}

//delegate int TestDelegate<T>(T a, T b);
//class Calculator
//{
//    public int Plus(int a, int b) { return a + b; }
//    public float Plus(float a, float b) { return a + b; }
//    public int Minus(int a, int b) { return a - b; }
//    public float Minus(float a, float b) { return a - b; }
//    public int Multiply(int a, int b) { return a * b; }
//    public float Multiply(float a, float b) { return a * b; }
//}

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