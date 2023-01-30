

int[] Array3nums()
{
    int[] array = new int[10];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(99, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine(array[array.Length - 1]);
}


int Check(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] % 2 == 0)
        {
            sum += 1;
        }

    }
    return sum;
}


int[] array1 = Array3nums();
int sum = Check(array1);
PrintArray(array1);
System.Console.WriteLine($"количество всех четных чисел массива = {sum}");