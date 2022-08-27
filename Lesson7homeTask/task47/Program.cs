// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double [,] CreateMatrix(int row, int col, int min, int max)
{
	
	
	double [,] matrix = new double [row,col];
    Random rnd=new Random();
	for (int i = 0; i < matrix.GetLength(0); ++i)
	{
		for (int j = 0; j <matrix.GetLength(1); j++)
        {
            matrix[i,j]=Math.Round (rnd.NextDouble ()*(max-min)-min,2,MidpointRounding.ToZero);
        }
        
        
        
	}

	return matrix;
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

Console.WriteLine("Программа для генерации матрицы заданного размера из вещественных чисел.");
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
