//Задача 1
/*
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
*/
//Задача 2
/*
int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for(int i = 0; i < n; i++)
        for(int j = 0; j < m; j++)
        matrix[i, j] = new Random().Next(10, 100);
    return matrix;
}

void FindByIndex(int num1, int num2, int[,] matrix)
{ 
    if(num1 >= matrix.GetLength(0)||num2 >= matrix.GetLength(1)||num1 < 0 || num2 < 0)
        Console.WriteLine("Incorrect index");
    else 
       Console.WriteLine($"{matrix[num1, num2]}");;
   

}
int I1, I2;
int[,] matrix = CreateMatrix(5, 5);

for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
        Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine("");
    }

Console.WriteLine("Enter the first index:");
   I1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the k1:");
   I2 = Convert.ToInt32(Console.ReadLine());

FindByIndex(I1, I2, matrix);
*/