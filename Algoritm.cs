namespace Sortlash_Algoritms
{
    public class Algoritm
    {
        public bool TubSon(int a)
        {
            bool tubSonmi = true;
            if(a == 1)
            {
                return !tubSonmi;
            }

            for(int i = 2; i <= Math.Sqrt(a); i++)
            {
                if(a % i == 0)
                {
                    tubSonmi = false;
                }
            }
            return tubSonmi;
        }
        // D:\Exam_PDP\Sortlash_Algoritms\Sortlash_Algoritms.csproj
        public int Fibonachi_Rekursiya(int a)
        {
            if (a == 1)
                return 0;
            else if(a == 2)
                return 1;

            return Fibonachi_Rekursiya(a - 1) + Fibonachi_Rekursiya(a - 2);
        }

        public int Fibonachi_For(int a)
        {
            int x = 0, y = 1, summ = 0;

            if (a == 1)
                return 0;
            else if (a == 2)
                return 1;

            for(int i = 0; i < a - 2; i++)
            {
                summ = x + y;
                x = summ - x;
                y = summ;
            }

            return summ;
        }

        public int EKUB(int a, int b)
        {
            int ekub = 1;
            for(int i = 1; i <= a; i++)
            {
                if(a % i == 0 && b % i == 0)
                {
                    ekub = i;
                }
            }

            return ekub;
        }

        public int EKUK(int a, int b)
        {
            // a * b = EKUB(a, b) * EKUK(a, b);
            int EKUK = a * b;
            for(int i = a * b; i > 0; i--)
            {
                if(i % a == 0 && i % b == 0)
                {
                    EKUK = i;
                }
            }

            return EKUK;
        }

        public int EKUK_1(int a, int b)
        {
            // a * b = EKUB(a, b) * EKUK(a, b);
            int EKUB = 1;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    EKUB = i;
                }
            }

            return (a * b) / EKUB;
        }

        public int Factorial(int a)
        {
            int summa = 1;
            for(int i = 1; i <= a; i++)
            {
                summa *= i;
            }

            return summa;
        }

        public int Factorial_Rekursiv(int a)
        {
            if (a <= 1)
                return 1;

            return a * Factorial_Rekursiv(a - 1);
        }
    }
}
