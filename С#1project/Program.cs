int num;
Console.Write("Enter a num ");
string input = Console.ReadLine();

if (int.TryParse(input, out num))
{
    if (num >= 1 && num <= 100)
    {
        if (number % 3 == 0 && number % 5 == 0)
        {
            Console.WriteLine("Fizz Buzz");
        }
    }
    else if (num % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (num % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }

    else
    {
        Console.WriteLine(num);
    }
}
else
{
    Console.WriteLine("Error");
}

}
else
{
    Console.WriteLine("Error 2");
}

Console.WriteLine("Enter your text : ");
string inputValue = Console.ReadLine();
Console.WriteLine("Enter a % ");
string inputpercentage = Console.ReadLine();
double percentage, value;
if (double.TryParse(inputValue, out value) && double.TryParse(inputPercentage, out percentage))
{
    
    double result = value * percentage / 100;

    
    Console.WriteLine($"{percentage}%  {value} = {result}");
}
else
{
    Console.WriteLine("Error");
}



string common = null;
string num;
Console.WriteLine("enter 4 digits : ");
for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"Enter number : {i + 1} : ");
    num = Console.ReadLine();
    common += num;
}
Console.WriteLine(common);

int[,] array = new int[5, 5];
Random rand = new Random();


Console.WriteLine("Massive :");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        array[i, j] = rand.Next(-100, 101);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}


int min = array[0, 0], max = array[0, 0];
int minIndex = 0, maxIndex = 0;
int indexCounter = 0;

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (array[i, j] < min)
        {
            min = array[i, j];
            minIndex = indexCounter;
        }
        if (array[i, j] > max)
        {
            max = array[i, j];
            maxIndex = indexCounter;
        }
        indexCounter++;
    }
}


int sum = 0;
int start = Math.Min(minIndex, maxIndex);
int end = Math.Max(minIndex, maxIndex);

indexCounter = 0;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (indexCounter > start && indexCounter < end)
        {
            sum += array[i, j];
        }
        indexCounter++;
    }
}

Console.WriteLine($"Min : {min}");
Console.WriteLine($"Max : {max}");
Console.WriteLine($"Sum : {sum}");