int [] CreateArray()
{
    int [] array = new int[10];
    Random rnd = new Random();
    for(int i=0; i<array.Length;i++)
    {
        array[i] = rnd.Next(-100,100);
    }
    return array;
}

int Sum(int[] array)
{
    int sum = 0;
    for (int i =1;i<array.Length; i+=2)
    {
        sum+=array[i];
    }
    return sum;
}

void PrintArray(int [] array)
{
    for (int i = 0; i<array.Length-1; i++)
    {
System.Console.Write(array[i]+",");
    }
    System.Console.WriteLine(array[array.Length-1]);
}

int [] array1 = CreateArray();
PrintArray(array1);
int sum = Sum(array1);
System.Console.WriteLine($"сумма всех нечентных ячеек в массиве = {sum}");