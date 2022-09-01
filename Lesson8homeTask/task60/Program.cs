// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

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
int [,,] CreateMatrix3D(int row, int col, int size)
{
	
	
	int [,,] matrix = new int [row,col,size];
    bool[] index=new bool [99];

    Random rnd=new Random();
    int temp=0;
    index [temp]=true;
    
	for (int i = 0; i < matrix.GetLength(0); ++i)
	{
		for (int j = 0; j <matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {   
                while (index [temp]==true)
                    {
                        temp=rnd.Next (10,99);
                        
                    }   
                  
                matrix[i,j,k]=temp;
                index[temp]=true;
            }
                    
                
                
        }
           
    }
        
        
      
        
	

	return matrix;
}

void PrintMatrix3D(int[,,] matrix)

{
	
	
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        
	    for (int j = 0; j < matrix.GetLength(1); j++)
	        {
		       for (int k = 0; k < matrix.GetLength(2); k++) Console.Write($"{matrix[i,j,k],4}({i},{j},{k}) ");            
       
            }  
          
        Console.WriteLine ();
    }
     Console.WriteLine ();
}


Console.WriteLine("Программа для генерации 3х мерной матрицы из неповторяющихся двухзначных чисел");
Console.WriteLine();
int row=Check("число строк матриц");
int col=Check("число столбцов матриц");
int size=Check("Глубину матрицы");
if (col*row*size>89) Console.WriteLine ("Матрицу такого размера нельзя заполнить неповторяющимися двухзначными числами");
else
{
    int [,,] array3D=CreateMatrix3D (row,col,size);
    PrintMatrix3D (array3D);
}
