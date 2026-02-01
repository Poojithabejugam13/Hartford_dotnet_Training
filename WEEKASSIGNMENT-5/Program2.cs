using System;
class Program
{
    static void Main()
    {
        string[] a = Console.ReadLine().Split();
        double xa = double.Parse(a[0]);
        double ya = double.Parse(a[1]);
        double ra = double.Parse(a[2]);
        string[] b = Console.ReadLine().Split();
        double xb = double.Parse(b[0]);
        double yb = double.Parse(b[1]);
        double rb = double.Parse(b[2]);
        double distSq = (xa - xb) * (xa - xb) + (ya - yb) * (ya - yb);
        double sumR = ra + rb;
        double diffR = Math.Abs(ra - rb);
        if (distSq < (ra - rb) * (ra - rb) && ra > rb)
        {
            Console.WriteLine("B is in A");
        }
        else if (distSq < (rb - ra) * (rb - ra) && rb > ra)
        {
            Console.WriteLine("A is in B");
        }
        else if (distSq < sumR * sumR && distSq > diffR * diffR)
        {
            Console.WriteLine("A and B intersect");
        }
        else
        {
            Console.WriteLine("A and B do not intersect");
        }
    }
}
