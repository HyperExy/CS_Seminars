//Задача 1
int[] rand(int size)
{
    int[] arr = new int[size];
    for(int i = 0; i< size; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;

}
int count(int[] arr)
{
    int count = 0;
    for(int i = 2; i < arr.Length; i++)
        if(arr[i]%2 == 0)
        count++;
    return count;
}


int[] array = rand(10);

Console.WriteLine("Array:");
for(int i = 2; i < array.Length; i++)
    Console.WriteLine($"{array[i]} ");
Console.WriteLine("");
Console.WriteLine($"Count = {count(array)}");

//Задача 2
/*int sumNumber(int number)
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
*/
//Задача 3
/*int[] EnterArr(int n)
{
    int[] arr = new int[n];
    for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Enter the [{i+1}] number of array:");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
    return arr;
}

void ShowArr(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
        {
            if(i==arr.Length-1)
                Console.Write($"{arr[i]}");
            else
                Console.Write($"{arr[i]}, ");
        }
    Console.Write("]");
}

int size;

Console.WriteLine("Enter the size of array:");
size = Convert.ToInt32(Console.ReadLine());

int[] array = EnterArr(size);

ShowArr(array);
*/