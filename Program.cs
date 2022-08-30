using System;
using System.Threading;

/* Point Program

namespace CSharp_Three
{
    class Point
    {
        private int x;
        private int y;
        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public string ShowData()
        {
            return $"X = {x} ; Y = {y}";
        }


    }
    internal class Program
    {
        static void Main()
        {
            Point point = new Point(3,4);
            Console.WriteLine(point.ShowData());
        }
    }
} */

/* Counter Program

namespace CSharp_Three
{
    class Counter
    {
        private int min;
        private int max;
        private int current;

        public Counter()
        {
            min = 0;
            max = 0;
            current = 0;
        }

        public Counter(int min, int max)
        {
            this.min = min;
            this.max = max;
            current = min;
        }

        public void increment()
        {
            if (current != max)
                ++current;
        }

        public void decrement()
        {
            if (current != min)
                --current;
        }

        public int getCurrent() => current;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter(0,100);
            counter.increment();
            counter.decrement();
            counter.increment();
            counter.decrement();
            Console.WriteLine(counter.getCurrent());
        }
    }
}*/

/* Timer Program
 
namespace Csharp_Three
{
    internal class Program
    {
        class Timer
        {
            private int min;
            private int max;

            private int current;

            public Timer()
            {
                min = 0;
                max = 60;
                current = min;
            }

            public Timer(int min, int max)
            {
                this.min = min;
                this.max = max;
                this.current = min;
            }

            public void start()
            {
                if (min == max)
                    throw new Exception("Minimum = Maximum!");
                else if (max < min)
                    throw new Exception("Maximum < Minimum!");
                else
                {
                    while (current != max)
                    {
                        current++;
                        Console.WriteLine(current);
                        Thread.Sleep(1000);
                        if (current == max)
                        {
                            Console.Clear();
                            current = min;
                        }
                    }
                }
            }
            static void Main(string[] args)
            {
                Timer timer = new Timer(0, 15);
                timer.start();
            }
        }
    }
} */

/* Fraction Calculator
 
namespace CSharp_Three
{
    class Fraction
    {
        private int _numerator;
        private int _denominator;

        public Fraction()
        {
            _numerator = 0;
            _denominator = 0;
        }
        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }
        public Fraction plus(ref Fraction other_fraction)
        {
            int numerator = (this._numerator * other_fraction._denominator) + (other_fraction._numerator * this._denominator);
            int denominator = this._denominator * other_fraction._denominator;

            int i = numerator;
            while (i != 1)
            {
                if (numerator % i == 0)
                    if (denominator % i == 0)
                        break;
                i--;
            }

            return new Fraction(numerator / i, denominator / i);
        }
        public Fraction minus(ref Fraction other_fraction)
        {
            int numerator = (this._numerator * other_fraction._denominator) - (other_fraction._numerator * this._denominator);
            int denominator = this._denominator * other_fraction._denominator;

            int i = numerator;
            while (i != 1)
            {
                if (numerator % i == 0)
                    if (denominator % i == 0)
                        break;
                i--;
            }

            return new Fraction(numerator / i, denominator / i);
        }
        public Fraction multiple(ref Fraction other_fraction)
        {
            int numerator = this._numerator * other_fraction._numerator;
            int denominator = this._denominator * other_fraction._denominator;


            int i = numerator;
            while (i != 1)
            {
                if (numerator % i == 0)
                    if (denominator % i == 0)
                        break;
                i--;
            }

            return new Fraction(numerator / i, denominator / i);
        }
        public Fraction divise(ref Fraction other_fraction)
        {
            int numerator = this._numerator * other_fraction._denominator;
            int denominator = this._denominator * other_fraction._numerator;


            int i = numerator;
            while (i != 1)
            {
                if (numerator % i == 0)
                    if (denominator % i == 0)
                        break;
                i--;
            }

            return new Fraction(numerator / i, denominator / i);
        }
        public override string? ToString()
        {
            return $"{_numerator}/{_denominator}";
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(5, 9);
            Fraction f2 = new Fraction(8, 9);

            Console.WriteLine(f1.divise(ref f2));
        }
    }
}*/