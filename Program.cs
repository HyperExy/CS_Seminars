//Задача 1
/*
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
*/
//Задача 2
/*
double CoordinateX(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1)/(k1-k2);
    return x;
}

double CoordinateY(double b1, double k1, double x)
{
    double y = k1 * x + b1;
    return y;
}
double b1, b2, k1, k2;

Console.WriteLine("Enter the b1:");
   b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the k1:");
   k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the b2:");
   b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the k2:");
   k2 = Convert.ToDouble(Console.ReadLine());
double X = CoordinateX(b1, b2, k1, k2);
double Y = CoordinateY(b1, k1, X);
Console.Write("Coordinate: ");
Console.WriteLine($"({X}, {Y})");
*/
