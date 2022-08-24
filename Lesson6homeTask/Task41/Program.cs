// Задача 41:
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int[] AskArraydIntSize(int size)
{
	
	
	int[] arr = new int[size];
	for (int i = 0; i < size; ++i)
	{
		Console.Write($"Введите элемент массива с индексом {i}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        
	}

	return arr;
}

bool [] GetPosIndex (int[] arr)
{
	bool [] arrPosNeg = new bool [arr.Length];
	
	for (int i = 0; i < arr.Length; i++)
	{
		    if (arr[i]>0) arrPosNeg[i]=true;
            else arrPosNeg[i]=false;
        
    }
	return arrPosNeg;
   }
int ContPos (bool [] indexArr)
{
	int count=0;
	
	for (int i = 0; i < indexArr.Length; i++)
	{
		    if (indexArr[i]==true) count++;
        
    }
	return count;
}
void PrintArray(int[] arr,bool [] indexArr)
{
	
	Console.Write("[");
	for (int i = 0; i < arr.Length - 1; i++)
	{
		
       if (indexArr[i]==true)
       {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"{arr[i]}, ");
        Console.ResetColor();
       }  
       else  Console.Write($"{arr[i]}, ");
       
    }
	
    if (indexArr[indexArr.Length-1]==true)
       {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"{arr[arr.Length - 1]}");
        Console.ResetColor();
        }   
    else Console.Write($"{arr[arr.Length - 1]}");
    Console.Write ("]");
    Console.WriteLine ();
}


Console.Clear ();

Console.WriteLine("Программа для поиска количества элементов массива больше нуля ");
Console.WriteLine();

int qty=-1;
do
{
    Console.Write("Введите число элементов массива: ");
    qty = Convert.ToInt32(Console.ReadLine());
    if (qty <0) Console.WriteLine("Ошибка: Число элементов должно быть положительным! Если хотите выйти введите, пожалуйста '0'");
    else if (qty==0) return;
    
} while (qty<0);


int [] array =AskArraydIntSize (qty);
bool [] PosElem=GetPosIndex (array);
int result=ContPos (PosElem);
PrintArray (array,PosElem);
if (result==0)  Console.WriteLine ("В массиве нет элементов больше нуля");
else Console.WriteLine ($"В массиве {result} элемента(ов) больше нуля");