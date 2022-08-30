//Задача 1
int  degree(int num1,int num2)
{
    int result = num1;
    for(int i = 2; i <= num2; i++)
        result *= num1;
    return result;
}
int A, B;

Console.WriteLine("Enter A:");
A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter B:");
B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{A} in degree of {B} is {degree(A, B)}");

//Задача 2

//Задача 3
