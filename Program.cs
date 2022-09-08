using System;

class MyNewClass
{

     static void Main()
    {
        System.Console.WriteLine("Задача 47: Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.");
        System.Console.WriteLine("Задача 50:Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и ");
        System.Console.WriteLine("          возвращает значение этого элемента или же указание, что такого элемента нет.");
        System.Console.WriteLine("Задача 52: Задайте двумерный массив из целых чисел.Найдите среднее арифметическое элементов в каждом столбце.");

        int Task = int.Parse(Console.ReadLine());
        switch (Task)
        {
            case 47: 
            {        
                System.Console.WriteLine("Введите количество строк ");
                int m = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Введите количество столбцов ");
                int n = int.Parse(Console.ReadLine());
                GetDoubleArr(m, n);
                break;
            }
            case 50:
            {
                int [,] Array = GetIntArr(10,10);
                PrintArr(Array);
                System.Console.WriteLine("Введите позиции искомого элемента через пробел");
                string [] rowCol = Console.ReadLine().Split(" ",  StringSplitOptions.RemoveEmptyEntries);
                System.Console.WriteLine(FindEl(Array, int.Parse(rowCol[0]), int.Parse(rowCol[1])));
                break;
            }
            case 52:
            {
                int [,] Array52 = GetIntArr(3, 8);
                PrintArr(Array52);

                double [] arithM = arithMean(Array52);
                System.Console.WriteLine("Среднее арифметическое каждого столбца");
                System.Console.WriteLine(string.Join("  ", arithM));
                break;
            }
            default: break;
        }     

    }

    public static void GetDoubleArr(int rows, int cols)
    {
        // Задайте двумерный массив размером m×n,
        // заполненный случайными вещественными числами.

        double[,] MyArr = new double[rows, cols];
        for (int i = 0; i < MyArr.GetLength(0); i++)
        {
            for (int j = 0; j < MyArr.GetLength(1); j++)
            {
                MyArr[i,j] =  Math.Round( new Random().Next(-10, 10) + new Random().NextDouble(), 2);
                System.Console.Write($"{MyArr[i,j]}  ");
            }
            System.Console.WriteLine();
        }
    }

    public static int[,] GetIntArr(int rows, int cols)
    {
        //Запоняет массив случайными целыми числами
        int [,] MyArr = new int[rows, cols];
        for (int i = 0; i < MyArr.GetLength(0); i++)
        {
            for (int j = 0; j < MyArr.GetLength(1); j++)
            {
                MyArr[i,j] =  new Random().Next(-10, 10);
            }
        }
        return MyArr;
    }

    public static void PrintArr(int [,] MyArr)
    {    
        // Печать массива
        for (int i = 0; i < MyArr.GetLength(0); i++)
        {
            for (int j = 0; j < MyArr.GetLength(1); j++)
            {
                MyArr[i,j] =  new Random().Next(-10, 10);
                System.Console.Write($"{MyArr[i,j]}  ");
            }
            System.Console.WriteLine();
        }
    }
    
    public static string FindEl(int [,] MyArr, int row, int col)
    {
       // ищет значение элемента по позиции
        if (row >= 0 && row < MyArr.GetLength(0)   && col >= 0  && col < MyArr.GetLength(1) )
        {
            return "Значение элемента "+ MyArr[row, col];
        } 
        else return "Такого элемента нет";
    }
    
    public static double [] arithMean(int [,] MyArr)
    {
        //Найдите среднее арифметическое элементов в каждом столбце.
         double [] arith = new double [MyArr.GetLength(1)];
         int sum = 0;
         for (int j = 0; j < MyArr.GetLength(1); j++)
         {
            for (int i = 0; i < MyArr.GetLength(0); i++ )
            {
                sum += MyArr[i,j];
            }
            arith[j] =Math.Round( Convert.ToDouble( sum )/ Convert.ToDouble( MyArr.GetLength(0) ), 2);
            sum = 0; 
         }
         return arith;
    }
}
