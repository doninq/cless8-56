/*Задача 56: Задайте прямоугольный двумерный массив. Н
апишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] GenerateArray(int n,int m)
{
    int[,] matrix = new int[n,m];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
       for(int j = 0; j < matrix.GetLength(1); j++)
       {        
           matrix[i,j] = new Random().Next(1, 10);
       }
    }return matrix; 
}

void PrintArray(int[,] matrix)
{
   for(int i = 0; i < matrix.GetLength(0); i++)
    {
       for(int j = 0; j < matrix.GetLength(1); j++)
       {
           Console.Write(matrix[i,j]+" ");
       }
       Console.WriteLine("");
    }
}

void MinSumArray(int[,] matrix)
{   
   int Sum = 0;
   int MinSum = 0;
   int Number = 0; 
   for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Sum = matrix[i,j]+Sum;
        } 
        if (i == 0) MinSum = Sum;
        if (Sum < MinSum) 
        {
            MinSum =  Sum;
            Number = i;
        }
        //Console.WriteLine(Sum + " " + MinSum);
        Sum = 0;
    }    
    Console.WriteLine("Номер строки с минимальной суммой: " + Number);
}

int[,] result = GenerateArray(3,4);
PrintArray(result);
//SortArray(result);
MinSumArray(result);
//PrintArray(result);
//
