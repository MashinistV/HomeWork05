//Задача 38. Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементом массива.

string ofer = "Введите число элементов массива: ";
int quantity = CheckNumber(ofer);
double[] randomArray = RandomArray(quantity, 20, -20);
Console.WriteLine($"Введён массив {string.Join(" ", randomArray)}");
double max = MaxNumber(randomArray);
Console.WriteLine($"Максимальное число в массиве: {max}");
double min = MinNumber(randomArray);
Console.WriteLine($"Минимальное число в массиве: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {max - min}");

double[] RandomArray(int length, double max, double min)
{
    double[] array = new double[length];
    Random randomarray = new Random();

    for (int count = 0; count < length; count++)
    {
        array[count] = Math.Round(min + randomarray.NextDouble() * (max - min), 2);
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

double MaxNumber(double[] array)
{
    double max = array[0];

    for (int index = 1; index < array.Length; index++)
    {
        if (array[index] > max)
        {
            max = array[index];
        }
    }
    
    return max;
}

double MinNumber(double[] array)
{
    double min = array[0];

    for (int index = 1; index < array.Length; index++)
    {
        if (array[index] < min)
        {
            min = array[index];
        }
    }
    
    return min;
}