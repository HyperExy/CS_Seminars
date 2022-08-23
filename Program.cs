//Задача 1 
/*int num;
int SecondNumber (int number)
{
    int temp = number % 100;
    temp /= 10;
    return temp;
}
Console.WriteLine("Enter the number:");

num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"2nd number of {num} is {SecondNumber(num)}:");
*/
//Задача 2
/*int ThirdNumber(int number)
{
    int temp = -1;
while(number > 99)
    {
    if(number <= 999)
        temp = number % 10;
    number/=10;
    }

return temp;
}
int num;

Console.WriteLine("Enter the number:");

num = Convert.ToInt32(Console.ReadLine());

int num1 = ThirdNumber(num);
if(num == -1)
    Console.WriteLine("No third number");
else
    Console.WriteLine($"Third number of {num} is {num1}");
*/
//Задача 3
/*void IsWeekend(int number)
{
    if(number == 6 || number == 7)
    Console.WriteLine("Its a weekend");
    else
    Console.WriteLine("Its not a weekend");
}
int num;

Console.WriteLine("Enter the number:");

num = Convert.ToInt32(Console.ReadLine());
IsWeekend(num);
*/