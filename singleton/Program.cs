using System;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;

            if (Object.ReferenceEquals(s1, s2))
                System.Console.WriteLine("Singleton is working.");
            else
                System.Console.WriteLine("Singleton is broken.");
        }
    }
}
