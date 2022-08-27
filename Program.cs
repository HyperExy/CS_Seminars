void isPolyndrome(int number)
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
