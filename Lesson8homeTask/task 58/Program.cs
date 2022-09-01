// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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

int [,] MultiplayMatrices (int [,] matrixA , int [,] matrixB)
{
	
    int sizeXResArray=Math.Min (matrixA.GetLength(0),matrixB.GetLength(0));
    int sizeYResArray=Math.Min (matrixA.GetLength(1),matrixB.GetLength(1));
    int [,] matrixC = new int [sizeXResArray,sizeYResArray];
	for (int i = 0; i < sizeXResArray; ++i)
	    {
	        for (int j = 0; j <sizeYResArray; j++)
                {
                    for (int k = 0; k < matrixA.GetLength(0); k++) matrixC[i,j]=matrixC[i,j]+(matrixA[i,k]*matrixB[k,j]);
                    
                }
           
        }
    return matrixC;
}
Console.WriteLine("Программа для перемножения матриц : ");
Console.WriteLine();
int row1=Check("число строк первой матрицы ");
int col1=Check("число столбцов первой матрицы");
int row2=Check("число строк второй матрицы ");
int col2=Check("число столбцов второй матрицы");

if (col1!=row2) Console.WriteLine ("Перемножить такие матрицы нельзя, так как число столбцов первой не равно числу строк второй");
else
{
int [,] array2DFirst=CreateMatrix (row1,col1,0,10);
int [,] array2DSecond=CreateMatrix (row2,col2,0,10);
// array2DFirst [0,0]=2;
// array2DFirst [0,1]=4;
// array2DFirst [1,0]=3;
// array2DFirst [1,1]=2;
// array2DSecond [0,0]=3;
// array2DSecond [0,1]=4;
// array2DSecond [1,0]=3;
// array2DSecond [1,1]=3;
PrintMatrix (array2DFirst);
Console.WriteLine();
PrintMatrix (array2DSecond);
int [,] resultMatrix=MultiplayMatrices (array2DFirst,array2DSecond);
Console.WriteLine("Результат перемножения элементов матриц.");
PrintMatrix (resultMatrix);
}