int num = 7891;

int max = 0;
int x;
while (num > 0)
{
    x = num % 10;
    if (x > max)
    {
        max = x;
    }
    num /= 10;
}
Console.WriteLine(max);