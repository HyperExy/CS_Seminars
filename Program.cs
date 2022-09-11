//Задача 1

double[,] CreateMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    for(int i = 0; i < n; i++)
        for(int j = 0; j < m; j++)
        matrix[i, j] = new Random().Next(10, 100) + new Random().NextDouble() ;
    return matrix;
}

Console.WriteLine("Enter the size m:");
    int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the size n:");
    int N = Convert.ToInt32(Console.ReadLine());
double[,] matrix = CreateMatrix(M, N);

for(int i = 0; i < N; i++)
    {
        for(int j = 0; j < M; j++)
        {
        Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine("");
    }

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
