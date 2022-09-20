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
    string[] result = (Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries));
    return result;
}
string[] input = Prompt("Введите значения через запятую в кавычках: ");
Console.WriteLine(String.Join(" ", input));
Console.WriteLine(input[0]);
