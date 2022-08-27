
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double [,] CreateMatrix(int row, int col, int min, int max)
{
	
	
	double [,] matrix = new double [row,col];
    Random rnd=new Random();
	for (int i = 0; i < matrix.GetLength(0); ++i)
	{
		for (int j = 0; j <matrix.GetLength(1); j++)
        {
            matrix[i,j]=rnd.Next (min,max+1);
        }
        
        
        
	}

	return matrix;
}

double [] AverageColMatrixFind (double[,] matrix)
{
	double [] averageCol= new double [matrix.GetLength(1)]; 
	
    double colsum=0; 
    for (int i = 0; i < matrix.GetLength(1); ++i)
    {
	    for (int j = 0; j < matrix.GetLength(0); j++)
	        {
                colsum=colsum+matrix[j,i];
                                       
            }
        averageCol[i]=Math.Round ((colsum/matrix.GetLength(0)),2,MidpointRounding.ToZero);
         colsum=0;
       
    }
    return averageCol;
}

void PrintMatrix(double[,] matrix)
{
	
	
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        Console.Write("[");
	    for (int j = 0; j < matrix.GetLength(1); j++)
	        {
		
                
               if (j<matrix.GetLength(1)-1) Console.Write($"{matrix[i,j],4}, ");
               else Console.Write($"{matrix[i,j],4}]");


        
            }  
        Console.WriteLine ();    
       
    }

}

void PrintArray(double[] arr)
{
	
	Console.Write("[");
	for (int i = 0; i < arr.Length - 1; i++)
	{
		
       Console.Write($"{arr[i],4}, ");
       
    }
	
    Console.Write($"{arr[arr.Length - 1],4}]");
    Console.WriteLine ();
}

	
       
    
    
    

Console.WriteLine("Программа для поиска среднего арифметического элементов в каждом столбце матрицы.");
Console.WriteLine();
int row=-1;
int col=-1;
do
{
    Console.Write("Введите число строк матрицы: ");
    row = Convert.ToInt32(Console.ReadLine());
    if (row <0) Console.WriteLine("Ошибка: Число должно быть положительным! Если хотите выйти введите, пожалуйста '0'");
    else if (row==0) return;
    
} while (row<0);
do
{
    Console.Write("Введите число столбцов матрицы: ");
    col= Convert.ToInt32(Console.ReadLine());
    if (col <0) Console.WriteLine("Ошибка: Число должно быть положительным! Если хотите выйти введите, пожалуйста '0'");
    else if (col==0) return;
    
} while (col<0);
double [,] array2D = CreateMatrix(row,col,0,9);
PrintMatrix (array2D);
double [] arrayAvarageCol=AverageColMatrixFind (array2D);
Console.WriteLine ();
PrintArray (arrayAvarageCol);