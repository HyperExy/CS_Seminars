//Задача 1
int count(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
        if(arr[i] > 0)
        count++;
    return count;
}
Console.WriteLine("Enter the size:");
    int M = Convert.ToInt32(Console.ReadLine());

int[] array = new int[M];

for(int i = 0; i < array.Length; i++)
        {
        Console.WriteLine($"Enter the [{i}] element");
        array[i] = Convert.ToInt32(Console.ReadLine());
        }
Console.WriteLine("");
Console.WriteLine($"Count = {count(array)}");

//Задача 2
/*
int[] rand(int size)
{
    int[] arr = new int[size];
    for(int i = 0; i< size; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
    return arr;

}

int sum(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
        if(i%2 == 1)
        sum+=arr[i];
    return sum;
}

int[] array = rand(5);

Console.WriteLine("Array:");
for(int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
Console.WriteLine("");
Console.WriteLine($"Sum = {sum(array)}");
*/
//Задача 3
/*
double[] rand(int size)
{
    double[] arr = new double[size];
    for(int i = 0; i< size; i++)
    {
        arr[i] = new Random().Next(0, 100) + new Random().NextDouble();
    }
    return arr;

}

double min(double[] arr)
{
    double min = arr[0];
    for(int i = 1; i < arr.Length; i++)
            if(min > arr[i])
                min = arr[i];
    return min;
}


double max(double[] arr)
{
    double max = arr[0];
    for(int i = 1; i < arr.Length; i++)
            if(max < arr[i])
                max = arr[i];
    return max;
}

double[] array = rand(10);

Console.WriteLine("Array:");
for(int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
Console.WriteLine("");

Console.WriteLine($"Diff = {max(array)-min(array)}");
*/