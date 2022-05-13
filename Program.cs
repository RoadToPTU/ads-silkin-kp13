Console.WriteLine("N:");
byte n = Convert.ToByte(Console.ReadLine());
Console.WriteLine("K:");
byte k = Convert.ToByte(Console.ReadLine());
int[] ar = new int[n];
byte a;
for (int i = 0; i < n; i++)
{
    a = Convert.ToByte(Console.ReadLine());
    if (a > 0)
    {
        ar[i] = a;
    }
    else
    {
        Console.WriteLine("error, enter positive number");
        i--;
    }
}
for (int i = 0; i < n; i++)
{
    if (ar[i] < k)
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
    Console.Write(ar[i] + " ");
}
Console.WriteLine();
int max = ar[0];
for (int i = 1; i < n; i++)
{
    if (ar[i] > max)
    {
        max = ar[i];
    }
}
int[] ar1 = new int[max + 1];
for (int i = 0; i <= max; i++)
{
    ar1[i] = 0;
}
for (int i = 0; i < n; i++)
{
    ar1[ar[i]]++;
}
int count = 0;
for (int i = k - 1; i >= 0; i--)
{
    for (int j = 0; j < ar1[i]; j++)
    {
        ar[count] = i;
        count++;
    }
}
for (int i = k; i <= max; i++)
{
    for (int j = 0; j < ar1[i]; j++)
    {
        ar[count] = i;
        count++;
    }
}

for (int i = 0; i < n; i++)
{
    if (ar[i] < k)
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
    Console.Write(ar[i] + " ");
}
