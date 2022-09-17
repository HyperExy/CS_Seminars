//Задача 1
/*
void ShowNNumbers(int m, int n)
{
    int Z = m, X = n;
    if(Z < X)
    {
        Console.Write(m + " ");
        if(m < n)
        {
            ShowNNumbers(m + 1, n);
        }
    }
    else if(Z > X)
    {
        Console.Write(n + " ");
        if(n < m)
        {
            ShowNNumbers(m, n + 1);
        }
    }
    else
        Console.Write(n + " ");
}

Console.WriteLine("Enter the size m:");
    int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the size n:");
    int N = Convert.ToInt32(Console.ReadLine());

ShowNNumbers(M, N);
*/
//Задача 2
/*
int ShowNNumbers(int m, int n)
{
    Console.Write(m + " ");
    if(m < n)
    {
        return  m + ShowNNumbers(m + 1, n);
    }
    else return m;
}


Console.WriteLine("Enter the size m:");
    int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the size n:");
    int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum = {ShowNNumbers(M, N)}");
*/
//Задача 3
