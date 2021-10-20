using System;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main()
        {

            
            int d, m, y, counter, a = 0,b =0;
            d = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());


            if ((y>300)||(y == 300&& (m >= 3 || (m == 2 && d == 29))))
            {
                if (m >= 3 || (m == 2 && d == 29))
                {
                    if ((((y - 300) % 400) - 1) >= 0)
                    {
                        counter = 1 + (((y - 300) / 400) * 3) + ((((y - 300) % 400) - 100) / 100);
                    }
                    else
                    {
                        counter = 1 + (((y - 300) / 400) * 3) + ((((y - 300) % 400)) / 100);
                    }
                    
                }
                else
                {
                    y = y - 1;
                    if ((((y - 300) % 400) - 1) >= 0)
                    {
                        counter = 1 + (((y - 300) / 400) * 3) + ((((y - 300) % 400) - 100) / 100);
                    }
                    else
                    {
                        counter = 1 + (((y - 300) / 400) * 3) + ((((y - 300) % 400)) / 100);
                    }
                    y++;
                }
            }
            else
            {
                if (m >= 3)
                {
                    counter = -2 + y / 100;
                }
                else
                {
                    y -= 1;
                    counter = -2 + y / 100;
                    y++;
                }
            }
            if (y % 4 == 0)
            {
                b++;
            }
            switch (m)
            {
                case 1:
                    
                        if (d + counter > 31)
                        {
                            d = d + counter - 31;
                                m++;
                       
                        }
                        else
                        {
                            d += counter;
                        
                        }
                    a = d + counter;
                    break;
                    
                case 2:
                    if (y % 4 == 0)
                    {
                        if (d + counter > 29)
                        {
                            d = d + counter - 29;
                            m++;
                        }
                        else
                        {
                            d += counter;
                        }
                       
                    }
                    else
                    {
                        if (d + counter > 28)
                        {
                            d = d + counter - 28;
                            m++;
                        }
                        else
                        {
                            d += counter;
                        }
                    }
                    a = 31 + d + counter;
                    break;
                case 3:

                    if (d + counter > 31)
                    {
                        d = d + counter - 31;
                        m++;
                    }
                    else
                    {
                        d += counter;
                    }
                    if (b != 0)
                    {
                        b = 29;
                        a = 31+ b + d + counter;
                    }
                    else
                    {
                        b = 28;
                        a +=31+ b + d + counter;
                    }
                    break;
                case 4:

                    if (d + counter > 30)
                    {
                        d = d + counter - 30;
                        m++;
                    }
                    else
                    {
                        d += counter;
                    }
                    a = 31 + b + 31 + d + counter;
                    break;
                case 5:

                    if (d + counter > 31)
                    {
                        d = d + counter - 31;
                        m++;
                    }
                    else
                    {
                        d += counter;
                    }
                    a = 31 + b + 31 + 30 + d + counter;
                    break;
                case 6:


                    if (d + counter > 30)
                    {
                        d = d + counter - 30;
                        m++;
                    }
                    else
                    {
                        d += counter;
                    }
                    a += 31 + b + 31 + 30 + 31 + d + counter;
                    break;
                case 7:

                    if (d + counter > 31)
                    {
                        d = d + counter - 31;
                        m++;
                    }
                    else
                    {
                        d += counter;
                    }
                    a = 31 + b + 31 + 30 + 31 + 30 + d + counter;
                    break;
                case 8:

                    if (d + counter > 31)
                    {
                        d = d + counter - 31;
                        m++;
                    }
                    else
                    {
                        d += counter;
                    }
                    a = 31 + b + 31 + 30 + 31 + 30 + 31 + d + counter;
                    break;
                case 9:


                    if (d + counter > 30)
                    {
                        d = d + counter - 30;
                        m++;
                    }
                    else
                    {
                        d += counter;
                    }
                    a = 31 + b + 31 + 30 + 31 + 30 + 31 + 31 + d + counter;
                    break;
                case 10:
                    if (d + counter > 31)
                    {
                        d = d + counter - 31;
                        m++;
                    }
                    else
                    {
                        d += counter;
                    }
                    a = 31 + b + 31 + 30 + 31 + 30 + 31 + 31 + 30 + d + counter;
                    break;
                case 11:

                    if (d + counter > 30)
                    {
                        d = d + counter - 30;
                        m++;
                    }
                    else
                    {
                        d += counter;
                    }
                    a = 31 + b + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + d + counter;
                    break;
                case 12:

                    if (d + counter > 31)
                    {
                        d = d + counter - 31;
                        y++;
                        m = 1;
                        a += - 31 + d + counter;
                    }
                    else
                    {
                        d += counter;
                    }
                    a = 31 + b + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30 + d + counter;
                    break;
            }
            Console.WriteLine(d + "." + m + "." + y + "." + counter);
            Console.WriteLine(a);
        }
    }
}