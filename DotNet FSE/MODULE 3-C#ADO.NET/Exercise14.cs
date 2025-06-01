﻿using System;

public class Exercise14
{
    class Shape
    {
        public virtual void Draw() => Console.WriteLine(""Drawing a Shape"");
    }

    class Circle : Shape
    {
        public override void Draw() => Console.WriteLine(""Drawing a Circle"");
    }

    class Rectangle : Shape
    {
        public override void Draw() => Console.WriteLine(""Drawing a Rectangle"");
    }

    public static void Main()
    {
        Shape s1 = new Circle();
        Shape s2 = new Rectangle();

        s1.Draw();
        s2.Draw();
    }
}
