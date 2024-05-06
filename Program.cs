int[] numbers = [2, 3, 101, 102, 103, 104, 101, 102, 103, 104, 105, 106, 200];

int length = 1;
int currLength = 1;

for (var i = 0; i < numbers.Length - 1; i++)
{
    if (numbers[i] + 1 == numbers[i+1])
    {
        currLength++;
    }
    else
    {
        if (currLength > length)
        {
            length = currLength;
        }
        currLength = 1;
    }
}

if (currLength > length)
{
    length = currLength;
}

Console.WriteLine(length);

