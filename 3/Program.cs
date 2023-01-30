double[] CreateArray()
{
    double[] array = new double[10];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 100) + rnd.NextDouble();
    }
    return array;
}


double Min(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

double Max(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

void PrintArray(double [] array)
{
    for(int i =0; i<array.Length-1; i++)
    {
        System.Console.Write($"{array[i]:f1}; ");
    }
    System.Console.WriteLine($"{array[array.Length-1]:f1}");
}

double[] array1 = CreateArray();
PrintArray(array1);
double min = Min(array1);
double max = Max(array1);
System.Console.WriteLine($"минимальное число {min:f1}");
System.Console.WriteLine($"максимальное число {max:f1}");;
System.Console.WriteLine($"разница между максимальным и минимальным = {max-min:f1}");