// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void PrintMatrix(int[,] matrix)

{
	
	
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        Console.Write("[");
	    for (int j = 0; j < matrix.GetLength(1); j++)
	        {
		        Console.Write($"{matrix[i,j],4} ");            
       
            }  
        Console.WriteLine ("]");    
       
    }

}

void MatrixRowMaxToMin (int [,] matrix, int rowNumber)
{

    for (int i = 0; i < matrix.GetLength (1); i++)
        {
            for (int j = 0; j < matrix.GetLength (1)-1; j++)
                {
                    if (matrix[rowNumber,j]<matrix [rowNumber,j+1])
                        {
                            int tmp =matrix [rowNumber,j];
                            matrix [rowNumber,j]=matrix [rowNumber,j+1];
                            matrix [rowNumber,j+1]=tmp;
                        }
                }    
        }
}
void MatrixSortMaxToMin (int [,] matrixToTrans)
{
for (int i = 0; i < matrixToTrans.GetLength (0); i++)
        {
            MatrixRowMaxToMin (matrixToTrans,i);
               
        }
}
Console.WriteLine("Программа для упорядычивания  по убыванию элементов каждой строки двумерного массива.");
Console.WriteLine();
int row=Check("число строк матрицы");
int col=Check("число столбцов матрицы");
int [,] array2D=CreateMatrix (row,col,0,10);
PrintMatrix (array2D);
MatrixSortMaxToMin (array2D);
Console.WriteLine();
Console.WriteLine("Отстортированная матрица");
Console.WriteLine();
PrintMatrix (array2D);