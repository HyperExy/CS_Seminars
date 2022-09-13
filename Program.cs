//Задача 1
/*
int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for(int i = 0; i < n; i++)
        for(int j = 0; j < m; j++)
        matrix[i, j] = new Random().Next(10, 100);
    return matrix;
}

void Sort(int[,] matrix)
{   
    int maxPosition;
    for(int i = 0; i< matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            maxPosition = j;
            for(int k = 0; k < matrix.GetLength(1); k++)
		    {
			    if(matrix[i,k] < matrix[i, maxPosition]) maxPosition = k;
			        int temp = matrix[i, j];
			    matrix[i, j]= matrix[i, maxPosition];
			    matrix[i, maxPosition] = temp;
		    }
        }
    }
}
Console.WriteLine("Enter the size m:");
    int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the size n:");
    int N = Convert.ToInt32(Console.ReadLine());
int[,] matrix = CreateMatrix(M, N);

Console.WriteLine("Before sort:");

for(int i = 0; i < N; i++)
    {
        for(int j = 0; j < M; j++)
        {
        Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine("");
    }
Sort(matrix);

Console.WriteLine("After sort:");

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

int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for(int i = 0; i < m; i++)
        for(int j = 0; j < n; j++)
        matrix[i, j] = new Random().Next(10, 100);
    return matrix;
}

int[] LineSum(int[,] matrix)
{ 
    int[] Sum = new int[matrix.GetLength(0)];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        Sum[i] = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
            Sum[i]+=matrix[i, j];
    }
    return Sum;
}

int FindMin(int[] Sum)
{
    int min = Sum[0], index = 0;
    for(int i = 1; i < Sum.Length; i++)
        if(min > Sum[i])
        {
            min = Sum[i];
            index = i;
        }
    return index;
}

int[,] matrix = CreateMatrix(4, 6);

for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
        Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine("");
    }

Console.WriteLine($"Number of line with min element: {FindMin(LineSum(matrix)) + 1}");


//Задача 3
/*
int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for(int i = 0; i < matrix.GetLength(0); i++)
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[j, i] = new Random().Next(10, 100);
    return matrix;
}

double[] Average(int[,] matrix)
{  
    double[] avg = new double[matrix.GetLength(1)];
    for(int i = 0; i < matrix.GetLength(1); i++)
        {
            avg[i] = 0;
            for(int j = 0; j < matrix.GetLength(0); j++)
                avg[i] += matrix[j, i];
            avg[i]/=matrix.GetLength(1);
        }
    return avg;

}

int[,] matrix = CreateMatrix(5, 5);
double[] average = Average(matrix);
for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
        Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine("");
    }
    Console.WriteLine("Averages is");
for(int i = 0; i < matrix.GetLength(1); i++)
    {
        Console.Write($"{average[i]} ");
    }
*/