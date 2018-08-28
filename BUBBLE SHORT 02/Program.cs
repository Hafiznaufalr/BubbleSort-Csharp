using System;
using static System.Console;

namespace BUBBLE_SHORT_02
{
    class Program
    {
        public void BUBBLESHORT(int[] A)
        {
            int N = A.Length-1;
            for (int X = 0; X < N - 1; X++)
                for (int Y = 0; Y < N- X;Y++)
                    if (A[Y] > A[Y+1])
                    {
                        int S = A[Y]; A[Y] = A[Y+1]; A[Y+1] = S;
                    }
        }
        public static void Main()
        {
            ForegroundColor = ConsoleColor.Red;
            int N;
            Write("\n Jumlah Data = "); N = int.Parse(ReadLine());
            int[] A = new int[N];
            WriteLine("\n Unsort Numbers : ");

            Random R = new Random();
            for (int X = 0; X < N; X++)
            {
                A[X] = R.Next(100, 1000); Write(" {0} ", A[X]);
            }

            Program P = new Program(); P.BUBBLESHORT(A);
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("\n\n Sorted Numbers : ");
            foreach (int X in A) Write(" {0} ", X);
            ReadKey();

        }
    }
}

