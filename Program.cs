//Задача 1
/*void isPolyndrome(int number)
{
    int output = number;
    int size = 0;

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
    bool pol = false;

    for(int i = 0, j = size - 1; i <= j; i++, j--)
            if(num[i]==num[j])
                    pol = true;
            else 
                {
                    pol = false;
                    break;
                }
    if(pol)
        Console.WriteLine($"Number {output} is a polyndrome");
    else
        Console.WriteLine($"Number {output} is not a polyndrome");

}
int num;

Console.WriteLine("Enter the number:");

num = Convert.ToInt32(Console.ReadLine());

isPolyndrome(num);
*/
//Задача 2
/*double Dist(int fx1, int fy1, int fz1, int fx2, int fy2, int fz2)
{
    double distance = Math.Sqrt(Math.Pow(fx2 - fx1, 2) + Math.Pow(fy2 - fy1, 2) + Math.Pow(fz2 - fz1, 2));
    return distance; 
}

int x1, y1, z1, x2, y2, z2;

Console.WriteLine("Enter the x1:");
x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the y1:");
y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the z1:");
z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the x2:");
x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the y2:");
y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the z2:");
z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Distance is : {Dist(x1, y1, z1, x2, y2, z2)}");
*/
//Задача 3
/*
void Cube(int number)
{
    int N = 1;
    while(N <= number)
    {
        Console.WriteLine(Math.Pow(N, 3));
        N++;
    }
}


int num;

Console.WriteLine("Enter the number:");

num = Convert.ToInt32(Console.ReadLine());
Cube(num);
*/