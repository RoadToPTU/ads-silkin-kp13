using System;

class Program
{
   
    
  

    static void Main(string[] args)
    {
        int count = 0;
        int swap;
        var r = new Random();
        int l = Int32.Parse(Console.ReadLine());
        int[] ar = new int[l];
        for (var i = 0; i < l; i++)
        {
            ar[i] = r.Next(-10000,10000);
        }
        for (var i = 0; i < l; i++)
        {
            if((ar[i]%2==0)&&(ar[i]<0))
            {
                Console.WriteLine(ar[i]);
                count++;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(ar[i]);
                Console.ResetColor();
            }
        }
        Console.WriteLine();
        int[] ar1 = new int[count];
        count = 0;
        for (var i = 0; i < l; i++)
        {
            if ((ar[i] % 2 == 0) && (ar[i] < 0))
            {
                ar1[count] = ar[i];
                count++;
            }
            
        }
        count = 0;
        var d = ar1.Length / 2;
        while (d >= 1)
        {
            for (var i = d; i < ar1.Length; i++)
            {
                var j = i;
                while ((j >= d) && (ar1[j - d] > ar1[j]))
                {
                    swap = ar1[j];
                    ar1[j] = ar1[j - d];
                    ar1[j - d] = swap;
                    j = j - d;
                }
            }

            d = d / 2;
        }
        for (var i = 0; i < l; i++)
        {
            if ((ar[i] % 2 == 0) && (ar[i] < 0))
            {
                 ar[i] = ar1[count];
                count++;
            }

        }
        for (var i = 0; i < l; i++)
        {
            if ((ar[i] % 2 == 0) && (ar[i] < 0))
            {
                Console.WriteLine(ar[i]);
                
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(ar[i]);
                Console.ResetColor();
            }
        }
        Console.ReadLine();
    }
}
