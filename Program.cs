using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       //var m1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
       //var m2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

       // var m3 = m1.Union(m2);
       // var m4 = m1.Intersect(m2);
       // var m5 = m1.Except(m2);
       // var m6 = m1.Concat(m2);

       // Console.WriteLine("Union: {0}", String.Join(" ", m3));
       // Console.WriteLine("Intersect: {0}", String.Join(" ", m4));
       // Console.WriteLine("Except: {0}", String.Join(" ", m5));
       // Console.WriteLine("Concat: {0}", String.Join(" ", m6));

        List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        Console.WriteLine("chose function");
        int n = int.Parse(Console.ReadLine());
        if (n == 1)
            Console.WriteLine("Section = " + String.Join(" ", list.Intersect(list2)));
        if (n == 2)
            Console.WriteLine("Union = " + String.Join(" ", list.Union(list2)));
        if (n == 3)
            Console.WriteLine("Difference = " + String.Join(" ", list.Except(list2)));
        if (n == 4)
            Console.WriteLine("Addition = " + String.Join(" ", list.Concat(list2)));
    }
}
