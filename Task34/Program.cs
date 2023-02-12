//Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

string ofer = "Введите число элементов массива: ";
int quantity = CheckNumber(ofer);
int[] randomArray = RandomArray(quantity, 100, 999);
Console.WriteLine($"Введён массив {string.Join(" ", randomArray)}");
int count = CountEvenFromArray(randomArray);
Console.WriteLine($"Количество чётных чисел в массиве: {count}");

int[] RandomArray(int length, int minvalue, int maxvalue)
{
    int[] array = new int[length];
    Random randomarray = new Random();

    for (int count = 0; count < length; count++)
    {
        array[count] = randomarray.Next(minvalue, maxvalue + 1);
    }

    return array;
}

int CheckNumber(string text)
{
    Console.Write(text);
    int number;

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Вы ввели не число");
        Console.Write("Введите число: ");
    }

    if (number <0) 
    {
        number = number * -1;
    }

    return number;
}

int CountEvenFromArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}