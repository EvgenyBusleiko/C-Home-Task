// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7
int Check (string textToPrint)
{
    int checkImput=-1;
    do
    {   
        Console.Write($"Введите {textToPrint}: ");
        checkImput = Convert.ToInt32(Console.ReadLine());
        if (checkImput<0) Console.WriteLine("Ошибка: Число должно быть положительным! Если хотите выйти введите, пожалуйста '0'");
        else if (checkImput==0) return checkImput=0;
    
    }
    while (checkImput<0);
    return checkImput;

}
int [,] CreateMatrix(int row, int col, int min, int max)
{
	
	
	int [,] matrix = new int [row,col];
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

void PrintMatrix(int[,] matrix,int rowIndex)

{
	
	
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        Console.Write("[");
        if (i==rowIndex) Console.ForegroundColor = ConsoleColor.Red;
        	    for (int j = 0; j < matrix.GetLength(1); j++)
	        {
		        Console.Write($"{matrix[i,j],4} ");            
       
            }  
        Console.ResetColor ();
        Console.WriteLine ("]");    
       
    }

}

int MatrixRowSum (int [,] matrix, int rowNumber)
{
    int sum=0;
    for (int j = 0; j < matrix.GetLength (1); j++)
        {
            sum+=matrix [rowNumber,j];
            

        }
    Console.WriteLine($"Cумма элементов в строке {rowNumber} ={sum} ");
    return sum;
}        

int MatrixMinRowIndexFind (int [,] matrixToCheck)
{
    int minSum=MatrixRowSum (matrixToCheck,0);
    int index=0;
    for (int i = 1; i < matrixToCheck.GetLength (0); i++)
        {
            int currentSum=MatrixRowSum (matrixToCheck,i);
            if (minSum>currentSum)
            {
                 minSum=currentSum;
                 index =i;
            }  
        }
    return index;
}

Console.WriteLine("Программа для поиска строки двумерного массива с минимальной суммой элементов.");
Console.WriteLine();
int row=Check("число строк матрицы");
int col=Check("число столбцов матрицы");
int [,] array2D=CreateMatrix (row,col,0,10);

Console.WriteLine();
int indexMinRow=MatrixMinRowIndexFind (array2D);
PrintMatrix (array2D,indexMinRow);
Console.WriteLine($"Минимальная сумма элементов в строке {indexMinRow}");