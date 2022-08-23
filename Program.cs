//Задача 1 
int num;
int SecondNumber (int number)
{
    int temp = number % 100;
    temp /= 10;
    return temp;
}
Console.WriteLine("Enter the number:");

num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"2nd number of {num} is {SecondNumber(num)}:");
