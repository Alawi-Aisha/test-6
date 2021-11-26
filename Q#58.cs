using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=2, b=3, c=5;

            //(a)
                ++a;
                Console.WriteLine("Valid Statement");
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);

            //(b)
                abc;
                Console.WriteLine("Invalid Statement");

            //(c)
                a++;
                Console.WriteLine("Valid Statement");
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);

            //(d)
                b+=a;
                Console.WriteLine("Valid Statement");
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);

            //(e)
                b+=a*c;
                Console.WriteLine("Valid Statement");
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);

            //(f)
                a++b;
                Console.WriteLine("Invalid Statement");

            //(g)
                a+=2;
                b=2/2;
                c=a*b;
                Console.WriteLine("Valid Statement");
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);

            //(h)
                ++b++;
                Console.WriteLine("Invalid Statement");

            //(i)
                b=a++ + b++;
                Console.WriteLine("Valid Statement");
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
        }
    }
}