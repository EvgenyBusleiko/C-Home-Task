// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет
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

void PrintMatrix(int[,] matrix, int xpos,int ypos)
{
	
	
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        Console.Write("[");
	    for (int j = 0; j < matrix.GetLength(1); j++)
	        {
		
                if (j<matrix.GetLength(1)-1) 
                {
                    if ((i==xpos) && (j==ypos))

                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{matrix[i,j],4}, ");
                        Console.ResetColor();

                    }
                    else Console.Write($"{matrix[i,j],4}, ");
                }
                else
                     if ((i==xpos) && (j==ypos))

                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"{matrix[i,j],4}");
                            Console.ResetColor();
                        }
                    
                        else Console.Write($"{matrix[i,j],4}");


        
            }  
        Console.WriteLine ("]");    
       
    }

}

Console.WriteLine("Программа для поиска элемента в матрице по индексам");
Console.WriteLine();
int row=Check("число строк матрицы");
int col=Check("число столбцов матрицы");


Console.WriteLine();

int x=Check("строку искомого элемента матрицы");
int y=Check("столбец искомого элеммента матрицы");

if ((x>row)|| (y>col)) Console.WriteLine("Ошибка: Такого элемента нет");
else
{
    int [,] array2D=CreateMatrix (row,col,0,9);
    PrintMatrix (array2D,x-1,y-1);
    Console.WriteLine ();
    Console.WriteLine($"Искомый элемент матрицы[{x},{y}]={array2D[x-1,y-1]}");
}
