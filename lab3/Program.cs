using System;

namespace RomanNumbers

{
    class Program

    {
        static void Main(string[] args)

        {

            try

            {
                RomanNumber a = new(0);

            }

            catch (RomanNumberException exp)

            {

                Console.WriteLine(exp.Message);

            }

            try

            {
                RomanNumber e = new(14);
                RomanNumber f = new(120);
                e -= f;
            }

            catch (RomanNumberException exp)

            {
                Console.WriteLine(exp.Message);
            }

            try

            {
                RomanNumber a = new(110);
                RomanNumber b = new(420);
                RomanNumber c = new(22);
                RomanNumber d = new(11);
                RomanNumber result;
                RomanNumber[] mas = { a, b, c, d };

                result = a + b;

                Console.WriteLine($"{a} + {b} = {result}");

                result = c / d;

                Console.WriteLine($"{c} / {d} = {result}");

                result = b - a;

                Console.WriteLine($"{b} - {a} = {result}");

                result = c * d;

                Console.WriteLine($"{c} * {d} = {result}");

                Console.WriteLine("Массив неотсортирован:");

                foreach (RomanNumber num in mas)

                {

                    Console.WriteLine(num);
                }

                Array.Sort(mas);
                Console.WriteLine("Массив отсортирован:");
                foreach (RomanNumber num in mas)

                {

                    Console.WriteLine(num);

                }

            }

            catch (RomanNumberException exp)

            {

                Console.WriteLine(exp.Message);

            }

        }

    }

}