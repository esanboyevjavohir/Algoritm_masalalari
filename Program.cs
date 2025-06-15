// See https://aka.ms/new-console-template for more information

using Sortlash_Algoritms;



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

//IkkiBaravar(ref a);
//Console.WriteLine(a); // => 20
