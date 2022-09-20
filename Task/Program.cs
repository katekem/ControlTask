// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
Console.Clear();
string[] Prompt(string message)
{
    Console.Write(message);
    string result = Console.ReadLine().Replace(",","");
    string[] array = result.Split(' ',StringSplitOptions.RemoveEmptyEntries);
    return array;
}

int CountNewArraySize(string[] array)
{int newArraySize = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
    newArraySize ++;
}
return newArraySize;
}

string[] input = Prompt("Введите значения через запятую без кавычек: ");

if (CountNewArraySize(input) == 0)
{
    Console.WriteLine("Трехзначных элементов нет");
}
else
{
    string newArray = string.Empty;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].Length <= 3)
            {
                newArray = $"{newArray} {input[i]}";
            }
        }
    string[] finalArray = newArray.Split(' ',StringSplitOptions.RemoveEmptyEntries);
    Console.WriteLine(String.Join(" ", finalArray));
}




