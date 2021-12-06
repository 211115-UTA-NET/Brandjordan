using System;
using System.IO;
using System.Collections.Generic;

namespace AbstractSampleNamespace

   /* abstract class Shape //Creates an abstract class
    {
        public abstract int GetArea();
    }
    class Square : Shape
    {
        private int _side;

        public Square(int n) => _side = n;

        // GetArea method is required to avoid a compile-time error.
        public override int GetArea() => _side * _side;

        static void Main()
        {
            var sq = new Square(12);
            Console.WriteLine($"Area of the square = {sq.GetArea()}");
        }
    }
    // Output: Area of the square = 144 */

    // Abstract class
abstract class BaseClass //DadClass is an base class
{
    //protected int _x = 100; //A protected member is accessible within its class and by derived class instances.
    //protected int _y = 150; //^^^^^^

    // Abstract method
    public abstract void AbstractMethod();
    // Abstract properties ^^^
    public abstract int X { get; }
    public abstract int Y { get; }
}

class DerivedClass : BaseClass
{
    public override void AbstractMethod()
    {
        _x++;
        _y++;
    }

    public override int X   // overriding property
    {
        get
        {
            return _x + 10;
        }
    }

    public override int Y   // overriding property
    {
        get
        {
            return _y + 10;
        }
    }

    static void Main()
    {
        var o = new DerivedClass();
        o.AbstractMethod();
        Console.WriteLine($"x = {o.X}, y = {o.Y}");
    }
}
// Output: x = 111, y = 161