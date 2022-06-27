using System;
using static System.Console;


class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int[,] A = new int[,]
        {
            {1,1,1,1,2,2,2,2,3,3,4,5 },
            {1,1,1,2,2,2,2,3,3,3,4,5},
            {1,2,2,2,3,3,3,3,4,4,4,5 },
            {1,2,3,3,3,4,4,4,4,5,5,5 },
            {1,2,3,3,4,4,4,4,5,5,5,5 }
        };
        int[] ESM = { 1, 2, 2, 3, 3 };
        int[] mincost = { 800, 650, 500, 400, 300 };
        int[] EGP = { 3, 3, 2, 2, 1 };
        int[] maxcost = { 6500, 6000, 5500, 5000, 4500 };
        int c = 2;
        for (int i = 0; i<12;i++)
        {
            int a = random.Next() % 12;
            int c1 = A[c,a];
            WriteLine("_____________________________________________");
            WriteLine($"{a}  {c1}  |  {ESM[c1-1]}  |   {mincost[c1-1]}   |    {EGP[c1-1]}    |    {maxcost[c1-1]}    |");
            c = c1 - 1;
        }
    }
}