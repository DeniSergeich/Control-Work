using System;
using static System.Console;

Console.Clear();

int elLimit = 3; // Создание переменной, которая ограничивает количество символов в строке

string[] Promt(string massage) // Ввод массива с клавиатуры
{
    Write(massage);
    string elArray = ReadLine();    
    string[] inArray = elArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    return inArray;
}

int GetLengthResultArray(string[] inArray) // Подсчет количества строк длиной <= 3 символа, для создания результирующего массива нужной длины
{    
    int count = 0;
    foreach (var item in inArray)
    {
        if (item.Length <= elLimit) count++;
    }
    return count;
}

string[] GetResultArray(string[] inArray, int lengthResultArray) // Создание и заполнение результирующего массива
{    
    int count = 0;
    string[] resultArray = new string[lengthResultArray];
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= elLimit)
        {
            resultArray[count] = inArray[i];
            count++;
        }
    }
    return resultArray;
}

void PrintResult(string[] inArray) // Вывод результата в консоль
{
    Write("Результат: ");
    foreach (var item in inArray)
    {
        Write($"{item} ");
    }
}

string[] inArray = Promt("Введите элементы массива через пробел: ");
int lengthResultArray = GetLengthResultArray(inArray);
string[] resultArray = GetResultArray(inArray, lengthResultArray);
PrintResult(resultArray);