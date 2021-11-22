using System;
using static System.Console;



class Program
{


    static void Main(string[] args)
    {
        
       
        var r = new Random();
        int n = Int32.Parse(ReadLine());
        int m = Int32.Parse(ReadLine());
        double k = Convert.ToDouble(ReadLine());
        double[,] ar = new double[n, m];
        
        double[,] ar2 = new double[n, m/2];
      
        double[,] arT = new double[n, m];
        for (int i = 0, c = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++, c++)
            {
                arT[i, j] = c;
            }
        }
        double[,] arR = new double[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                arR[i, j] = r.Next();
            }
        }

    mark:
        WriteLine("1 - тестовая матрица, 2 - рабочая матрица");

        switch (ReadLine())
        {
            case "1": ar = arT; break;
            case "2": ar = arR; break;
            default: goto mark;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m / 2; j++)
            {
                ar2[i, j] = ar[i, (j + m / 2)];
            }
        }
      
       
        WriteLine(ar[n-1, 0]);
        if (ar[n-1, 0] > k)
        {
            WriteLine(" index: " + (n-1) + "," + 0);
        }
        WriteLine(ar[n-2, 0]);
        if (ar[n-2, 0] > k)
        {
            WriteLine(" index: " + (n-2) + "," + 0);
        }
        int e = n-2, g = 0;
        int des = 1;
        int funk = 0;
        while (funk < (n * m / 2) - 2)
        {
            if (des == 1)
            {
                if (e < (n-1) && g < (m/2 -1))
                {
                    e++;
                    g++;
                    WriteLine(ar[e, g] + "  ");
                    if (ar[e, g] > k)
                    {
                        WriteLine(" index: " + e + "," + g);
                    }
                    funk++;
                }
                else
                {
                    if (e == (n - 1) && g != (m / 2 - 1))
                    {
                        g++;
                        WriteLine(ar[e, g] + "  ");
                        if (ar[e, g] > k)
                        {
                            WriteLine(" index: " + e + "," + g);
                        }
                        des = 2;
                        funk++;
                    }
                    else
                    {
                        if (g == (m / 2 - 1))
                        {
                            e--;
                            WriteLine(ar[e, g] + "  ");
                            if (ar[e, g] > k)
                            {
                                WriteLine(" index: " + e + "," + g);
                            }
                            des = 2;
                            funk++;
                        }
                    }
                }
            }
            if (des == 2)
            {
                if (e > 0 && g > 0)
                {
                    e--;
                    g--;
                    WriteLine(ar[e, g] + "  ");
                    if (ar[e, g] > k)
                    {
                        WriteLine(" index: " + e + "," + g);
                    }
                    funk++;
                }
                else
                {
                    if (g == 0 && e != 0)
                    {
                        e--;
                        WriteLine(ar[e, g] + "  ");
                        if (ar[e, g] > k)
                        {
                            WriteLine(" index: " + e + "," + g);
                        }
                        des = 1;
                        funk++;
                    }
                    else
                    {
                        if (e == 0)
                        {
                            g++;
                            WriteLine(ar[e, g] + "  ");
                            if (ar[e, g] > k)
                            {
                                WriteLine(" index: " + e + "," + g);
                            }
                            des = 1;
                            funk++;
                        }
                    }
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m / 2; j++)
            {
                WriteLine(ar2[i, j]);
                if (ar2[i, j] > k)
                {
                    WriteLine(" index: " + i + "," + (j+m/2));
                }
            }
            if (i < n -1 )
            {
                i++;
                for (int j = (m / 2) - 1; j >= 0; j--)
                {
                    WriteLine(ar2[i, j]);
                    if (ar2[i, j] > k)
                    {
                        WriteLine(" index: " + i + "," + (j+m/2));
                    }
                }
            }
        }



        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {

                Console.Write(ar[i, j] + "\t");


            }
            Console.WriteLine();
        }

    }
}



