//Задача 1
/*int  degree(int num1,int num2)
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
*/
//Задача 2
int sumNumber(int number)
{
    int output = number;
    int size = 0, sum = 0;
    while(number >= 1)
    {
        number/=10;
        size++;
    }
    int index = size - 1;
    int[] num = new int[size];
    number = output;
    while(index>=0)
    {
        num[index] = number%10;
        number/=10;
        index--;
    }
   for(int i = 0; i < size; i++)
        sum+=num[i];
    return sum;
}

int num;

Console.WriteLine("Enter the number:");
num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of numbers in {num} = {sumNumber(num)}");
//Задача 3
