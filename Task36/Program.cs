//Задача 36. Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

string ofer = "Введите число элементов массива: ";
int quantity = CheckNumber(ofer);
int[] randomArray = RandomArray(quantity, -9, 9);
Console.WriteLine($"Введён массив {string.Join(" ", randomArray)}");
int sum = SumOddFromArray(randomArray);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях в массиве: {sum}");

int SumOddFromArray(int[] array)
{
    int sum = 0;

    for (int index = 0; index < array.Length; index = index + 2)
    {
        sum = sum + array[index];
    }

    return sum;
}

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