using System;
    public class SLNode
{
    public SLNode(int d)
    {
        data = d;
    }
    public int data { get; set; }
    public SLNode next { get; set; }

    public SLNode copy()
    {
        var n = new SLNode(data);
        n.next = next;
        return n;
    }
}

public class List
{
    SLNode head;
    int count;
    public void AddFirst(int d)
    {
        if (head == null)
        {
            count = 1;
            head = new SLNode(d);
            head.next = head;
        }
        else
        {

            SLNode nod = head.copy();
            head.data = d;
            head.next = nod;
            count++;
        }
    }
    public void AddLast(int d)
    {
        if (head == null)
        {
            count = 1;
            head = new SLNode(d);
            head.next = head;
        }
        else
        {
            var last = head;
            for (int i = 0; i < count - 1; i++)
            {
                last = last!.next;
            }
            SLNode n_last = new SLNode(d);
            last!.next = n_last;
            n_last.next = head;
            count++;
        }
    }
    public void AddAtPosition(int d, int pos)
    {
        if (pos == 0)
        {
            AddFirst(d);
        }
        else
        {
            var nth = head;
            for (int i = 0; i < pos - 1; i++)
            {
                nth = nth!.next;
            }
            SLNode neww = new SLNode(d);
            neww.next = nth!.next;
            nth!.next = neww;
            count++;
        }
    }
    public void DeleteFirst()
    {
        var last = head;
        for (int i = 0; i < count - 1; i++)
        {
            last = last!.next;
        }
        head = head!.next;
        last!.next = head;
        count--;
    }
    public void DeleteLast()
    {
        var last = head;
        for (int i = 0; i < count - 2; i++)
        {
            last = last!.next;
        }
        last!.next = head;
        count--;
    }

    public void DeleteAtPosition(int pos)
    {
        if (pos == 0)
        {
            DeleteFirst();
        }
        else
        {
            var nth = head;
            for (int i = 0; i < pos - 1; i++)
            {
                nth = nth!.next;
            }
            nth!.next = nth!.next.next;
            count--;
        }
    }
    public void AddFunc(int d)
    {
        int? s = null;
        int r = 0;
        var nod = head;
        for (int i = 0; i < count; i++)
        {
            if (nod!.data %2 == 1)
            {
                s = i;
                break;
               
            }
            r++;
        }
        if ((s == null)||r==0)
        {
            AddFirst(d);
        }
        else
        {
            AddAtPosition(d, (int)s - 1);
        }
    }
    public void Print()
    {
        var nod = head;
        for (int i = 0; i < count; i++)
        {
            Console.Write($"{nod!.data} ");
            nod = nod.next;
        }
        Console.WriteLine();
    }
}
class Program
{
    static void Main(string[] args)
    {
        List List = new List();
        Console.WriteLine("First element:");
        List.AddFirst(int.Parse(Console.ReadLine()!));
        while (true)
        {
            List.Print();

            Console.WriteLine("\n1 AddFirst\n2 AddLast\n3 AddAtPosition\n4 DeleteFirst\n5 DeleteLast\n6 DeletAtPosition\n7 Print \n8 AddFunc");
            switch (Console.ReadLine())
            {
                case "1": List.AddFirst(int.Parse(Console.ReadLine()!)); break;
                case "2": List.AddLast(int.Parse(Console.ReadLine()!)); break;
                case "3": List.AddAtPosition(int.Parse(Console.ReadLine()!), int.Parse(Console.ReadLine()!)); break;
                case "4": List.DeleteFirst(); break;
                case "5": List.DeleteLast(); break;
                case "6": List.DeleteAtPosition(int.Parse(Console.ReadLine()!)); break;
                case "7": List.Print(); break;
                case "8": List.AddFunc(int.Parse(Console.ReadLine()!)); break;
                default: Console.WriteLine("Error"); break;
            }
        }
    }
}
