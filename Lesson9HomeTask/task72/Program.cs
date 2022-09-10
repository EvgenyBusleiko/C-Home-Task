// 1. Дано слово, состоящее только из строчных латинских букв.
//  Проверить, является ли это слово палиндромом. Вывести "Да" или "Нет".

string CheckNullStrins ()
{
    string stringToCheck="";
    do
    {   
        Console.Write("Введите слово из латинских строчных букв:  ");
        stringToCheck = Console.ReadLine();
        if (stringToCheck=="") Console.WriteLine("Ошибка: Введена пустая строка Если хотите выйти введите, пожалуйста 'E'");
        else if (stringToCheck=="E") return stringToCheck="E";
    
    }
    while (stringToCheck=="");
    return stringToCheck;

}

string ReversString (string wordToRevers)

{
    if (wordToRevers=="") return wordToRevers;
    else return ReversString(wordToRevers.Substring(1)) + wordToRevers[0];
}

Console.WriteLine ("Программа для определения, является ли слово полиномом");

string word = CheckNullStrins ();


if (word!="E")
{
    string word_UP=word.ToUpper();
    string reversed_Word=ReversString (word_UP); 

    if (word_UP==reversed_Word) Console.WriteLine ($"{word_UP} наоборот будет {reversed_Word} и это ПОЛИНОМ!");
    else Console.WriteLine ($"{word_UP} наоборот будет {reversed_Word} и это НЕ ПОЛИНОМ!");
}