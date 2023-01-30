/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с  клавиатуры, либо задать на старте выполнения алгоритма.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

Console.Clear();

void FillArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

string[] originalArray =
        {"Hello", "2", "world", ":-)",
        "1234", "1567", "-2", "computer science",
        "Russia", "Denmark", "Kazan"};
string[] resArray = new string[originalArray.Length];

FillArray(originalArray, resArray);
resArray = resArray.Where(x => x != null).ToArray();

Console.WriteLine($"Из исходного строчного массива получен новый,");
Console.WriteLine($"соответствующий условию задачи:");
Console.WriteLine($"\n" + "[" + String.Join(", ", originalArray)
                 + "] -> [" + String.Join(", ", resArray)
                 + "]" + "\n");