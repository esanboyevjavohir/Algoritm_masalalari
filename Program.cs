// See https://aka.ms/new-console-template for more information

using Sortlash_Algoritms;
using System.Collections;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {
        Console.WriteLine("X = "+X+", Y = "+Y);
    }
}

internal class Program
{
    static void Kvadrat(ref int son)
    {
        son = son * son;
    }

    static void IkkiSonniQaytar(out int a, out int b, out int summ)
    {
        a = 14;
        b = 26;
        summ = a + b;
    }

    public Tuple<string, int, int> GetStudent()
    {
        return Tuple.Create("Azam", 23, 3);
    }

    public (string Name, int Age) GetPerson()
    {
        return ("Jamshid", 30);
    }

    private static void Main(string[] args)
    {
        var valueTuple = (Id: 1, Name: "Alijon",Passed: false);
        Console.Write(valueTuple.Name+"\n");
        Console.Write(valueTuple.Id);

        var tuple = new Tuple<int, string, bool>(1, "Ali", true); 

        Program program = new Program();
        var student = program.GetStudent();

        //Console.Write($"Ismi : {student.Item1}, Yoshi : {student.Item2}, Kursi : {student.Item3}");

        IEnumerable<int> GetNumbers()
        {
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
        }

        foreach(int son in GetNumbers())
        {
            //Console.WriteLine(son);
        }

        ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Insert(1, "Zurku");
        arrayList.Add('t');
        arrayList.Contains(1);
        //arrayList.Remove(1);
        arrayList.RemoveAt(0);

        foreach (object obj in arrayList)
        {
            //Console.WriteLine(obj);
        }

        string[] massiv = {"Ali", "Vali", "Axmad", "Guli"};
        massiv[3] = "Zicha";

        foreach (string item in massiv)
        {
            //Console.Write(item+", ");
        }

        Point p1 = new Point(10, 20);
        Point p2 = p1;

        p2.X = 55;

        //p1.Display();
        //p2.Display();

        int[] array = { 5, 3, 8, 2, 11, 6, 5, 8, 24, 2 };

        //C c1 = new C();

        #region Ref_and_Out
        //string kirish = "123";
        //if(int.TryParse(kirish, out int natija))
        //{
        //    Console.WriteLine("Son = "+natija.GetType() +", "+ kirish.GetType());
        //}
        //else
        //    Console.WriteLine("!!!");

        //int a = 5;
        //Kvadrat(ref a);
        //Console.WriteLine(a);

        //int x = 5, y, summa;
        //IkkiSonniQaytar(out x, out y, out summa);
        //Console.WriteLine("x = "+x+ "\ny = "+y+ "\nsumma = "+summa); 
        #endregion

        #region Massivdan_Takrorlarni_Olib_Tashlash
        //int[] sonlar = {5, 3, 8, 2, 11, 6, 5, 8, 24, 2};

        //int[] newSonlar = sonlar.Distinct().ToArray();

        //foreach(int i in newSonlar)
        //{
        //    Console.Write(i + ", ");
        //} 
        #endregion

        #region Massivni_Eng_Katta_Elementini_Topish
        //int[] massiv = { 78, 3, 65, 8, 4, 25, 2, 7, 13, 1, 100 };

        //int kattaSon = 0;
        //for(int i = 0; i < massiv.Length; i++)
        //{
        //    kattaSon = massiv[0];
        //    for (int j = 1; j < massiv.Length; j++)
        //    {
        //        if(kattaSon < massiv[j])
        //        {
        //            kattaSon = massiv[j];
        //        }
        //    }
        //} 

        //Console.Write("Massivdagi katta element = " + kattaSon);
        #endregion

        #region Factorial_Rekursiv
        //Console.Write("son = ");
        //int x = int.Parse(Console.ReadLine());

        //var factorial = new Algoritm();
        //var result = factorial.Factorial_Rekursiv(x);

        //Console.Write("Sonning factoriali = " + result); 
        #endregion

        #region Factorial_For
        //Console.Write("son = ");
        //int x = int.Parse(Console.ReadLine());

        //var factorial = new Algoritm();
        //var result = factorial.Factorial(x);

        //Console.Write("Sonning factoriali = " + result); 
        #endregion

        #region EKUK
        //Console.Write("son1 = ");
        //int son1 = int.Parse(Console.ReadLine());
        //Console.Write("son2 = ");
        //int son2 = int.Parse(Console.ReadLine());

        //var ekub = new Algoritm();
        //var result = ekub.EKUK_1(son1, son2);

        //Console.Write("Ikki sonning Ekuki = " + result); 
        #endregion

        #region EKUB
        //Console.Write("son1 = ");
        //int son1 = int.Parse(Console.ReadLine());
        //Console.Write("son2 = ");
        //int son2 = int.Parse(Console.ReadLine());

        //var ekub = new Algoritm();
        //var result = ekub.EKUB(son1, son2);

        //Console.Write("Ikki sonning Ekubi = " + result); 
        #endregion

        #region Fibonachi_For
        //Console.Write("nechinchi fibonachi son kerak : ");
        //int x = int.Parse(Console.ReadLine());
        //var fibo = new Algoritm();
        //int result = fibo.Fibonachi_For(x);
        //// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89
        //Console.Write("Natija = " + result); 
        #endregion

        #region Fibonachi_Rekursiya
        //Console.Write("nechinchi fibonachi son kerak : ");
        //int x = int.Parse(Console.ReadLine());
        //var fibo = new Algoritm();
        //int result = fibo.Fibonachi_Rekursiya(x);
        //// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34
        //Console.Write("Natija = " + result); 
        #endregion

        #region TubSonmi
        //Console.Write("son = ");
        //int a = int.Parse(Console.ReadLine());
        //var tub = new Algoritm();
        //bool result = tub.TubSon(a);

        //Console.Write("natija : " + result); 
        #endregion

        #region MassivSortlash
        //int[] asad = new int[] {3, 23, 7, 13, 4, 8, 6, 10, 5};

        //for(int i = 0; i < asad.Length; i++)
        //{
        //    for(int j = 1; j < asad.Length - 1; j++)
        //    {
        //        int replase;
        //        if (asad[j] > asad[j+1])
        //        {
        //            replase = asad[j+1];
        //            asad[j + 1] = asad[j];
        //            asad[j] = replase;
        //        }
        //    }
        //}

        //for(int i = 0; i < asad.Length; i++)
        //{
        //    Console.Write(asad[i] + ", ");
        //} 
        #endregion

        #region Biror songacha bolgan mukammal sonlar
        //Console.Write("a = ");
        //int a = int.Parse(Console.ReadLine());
        //bool mukammalSonBormi = false;

        //Console.WriteLine(a + " gacha bo'lgan mukammal sonlar");
        //for (int son = 2; son <= a; son++)
        //{
        //    int summa = 0;
        //    for (int j = 1; j <= son / 2; j++)
        //    {
        //        if (son % j == 0)
        //        {
        //            summa += j;
        //        }
        //    }

        //    if (summa == son)
        //    {
        //        Console.Write(son + " mukammal son\n");
        //        mukammalSonBormi = true;
        //    }
        //}

        //if (mukammalSonBormi == false)
        //{
        //    Console.WriteLine(a + " gacha mukammal son yo'q");
        //} 
        #endregion

        #region TubSonmi?
        /*Console.Write("son = ");
        int son = int.Parse(Console.ReadLine());

        bool tubSonmi = true;

        if (son < 2)
            tubSonmi = false;

        for (int i = 2; i < Math.Sqrt(son); i++)
        {
            if (son % i == 0)
            {
                tubSonmi = false;
                break;
            }
        }

        if (tubSonmi)
        {
            Console.Write(son + " tub son");
        }
        else
            Console.Write(son + " tub son emas!!!");*/
        #endregion

        #region MukammalSonmi?
        /*int summ = 0;
        for(int i = 1; i < a; i++)
        {
        if(a % i == 0)
        {
        summ += i;
        }
        }

        if(summ == a)
        {
        Console.WriteLine($"{a} mukammal son.");
        }
        else
        {
        Console.WriteLine($"{a} mukammal son emas.");
        }*/
        #endregion

        #region SonniDarajagaKotarish
        //int result = 1;
        //for(int i = 0; i < b; i++)
        //{
        //    result = result * a;
        //}
        //Console.Write("javob = " + result);

        //double natija = Math.Pow(a, b);

        //Console.Write("natija = " + natija); 
        #endregion

        #region MassivSortlash
        //int[] massiv = { 5, 3, 8, 4, 2, 7, 13, 1 };

        //for (int i = 0; i < massiv.Length; i++)
        //{
        //    for (int j = 0; j < massiv.Length - 1; j++)
        //    {
        //        if (massiv[j] > massiv[j + 1])
        //        {
        //            //int a = massiv[j + 1];
        //            //massiv[j + 1] = massiv[j];
        //            //massiv[j] = a;
        //        }
        //    }
        //}

        //for (int i = 0; i < massiv.Length; i++)
        //{
        //    Console.Write(massiv[i] + ", ");
        //}
        #endregion

        static void IkkiBaravar(ref int son)
        {
            son = son * 2;
        }
    }
}
//IkkiBaravar(ref a);
//Console.WriteLine(a); // => 20
