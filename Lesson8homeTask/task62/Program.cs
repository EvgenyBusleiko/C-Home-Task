// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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
int [,] FillMatrixbySpiral(int row, int col)
{
	
	int [,] matrix = new int [row,col];
    int size=row;
    int count=1;
    int maxI=size-1;
    int minI=1;
    int maxJ=size-1;
    int minJ=0;
    int i=0;
    int j=0;
while (count<size*size)
    {
    while (j<maxJ)
        {
            matrix[i,j]=count;
            count++;
            j++;
        }
    maxJ=j-1;
    while (i<maxI)
        {
            matrix[i,j] = count;
            count++;
            i++;
        }
    maxI--;
    while (j>minJ)
        {
            matrix[i,j]=count;
            count++;
            j--;
        }
    minJ++;
    while (i>minI)
        {
            matrix[i,j] = count;
            count++;
            i--;
        }
    minI++;
    
    }
    matrix[i,j] = count;
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
Console.WriteLine("Программа для заполнения двумерного массива числами по спирали.");
Console.WriteLine();
int size=Check("число строк матрицы = число столбцов");

int [,] array2D=FillMatrixbySpiral (size,size);

Console.WriteLine();

PrintMatrix (array2D);

