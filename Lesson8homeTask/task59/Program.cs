// Задача 59: 
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

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

int [] FindMinElemIndex (int[,] matrix)
{
	
	
	int [] index = new int [2];
    int min=matrix[0,0];
	for (int i = 0; i < matrix.GetLength(0); ++i)
	{
		for (int j = 0; j <matrix.GetLength(1); j++)
        {
            if (matrix[i,j]<min)
            {
                min=matrix[i,j];
                index[0]=i;
                index[1]=j;
            }

        }
        
       
        
	}
    return index;
	
}

int [,] DeletMatrixColRow (int[,] matrix,int x, int y)
{
	int sizeX=matrix.GetLength(0)-1;
    int sizeY=matrix.GetLength(1)-1;

	
	int [,] newMatrix = new int [sizeX, sizeY];
    
	for (int i = 0; i < matrix.GetLength(0); ++i)
	{
		
        for (int j = 0; j <matrix.GetLength(1); j++)
        {   
            if ((i==x)||(j==y)) continue; 
            int newRow = i<x ? i:i-1;
            int newCol = j<y ? j:j-1;
            newMatrix [newRow,newCol]=matrix [i,j];
           

        }
        
       
        
	}
    return newMatrix;
	
}

	
void PrintMatrix(int[,] matrix,int rowIndex,int colIndex)

{
	
	
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        Console.Write("[");
        
        	    for (int j = 0; j < matrix.GetLength(1); j++)
	        {
                if ((i==rowIndex) && (j==colIndex)) Console.ForegroundColor = ConsoleColor.Red;
		        Console.Write($"{matrix[i,j],4} ");    
                Console.ResetColor ();        
       
            }  
        
        Console.WriteLine ("]");    
       
    }

}
Console.WriteLine("Программа для удаления строки и столбца двумерного массива, содержащего наименьший элемент");
Console.WriteLine();
int row=Check("число строк матрицы");
int col=Check("число столбцов матрицы");
int [,] array2D=CreateMatrix (row,col,0,99);
int [] indexMinElem =FindMinElemIndex (array2D);
PrintMatrix (array2D,indexMinElem[0],indexMinElem[1]);
int [,] newArray2D=DeletMatrixColRow (array2D,indexMinElem[0],indexMinElem[1]);
Console.WriteLine();
PrintMatrix (newArray2D,-1,-1);