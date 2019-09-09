using System;



namespace ClassLibrary
{
    public abstract class Shape
    {
        public string color;

        public Shape(string color)
        {
            this.color = color;
        }
    }
    public abstract class Quadralaterals : Shape
    {
        public int side1Length;
        public int side2Length;
        public int side3Length;
        public int side4Length;

        public Quadralaterals(string color, int side1Length, int side2Length, int side3Length, int side4Length) : base(color)
        {
            this.side1Length = side1Length;
            this.side2Length = side2Length;
            this.side3Length = side3Length;
            this.side4Length = side4Length;
        }

        public Quadralaterals(int side1Length, string color) : base(color)
        {
            this.side1Length = side1Length;
        }

        public Quadralaterals(int side1Length, int side2Length, string color) : base (color)
        {
            this.side1Length = side1Length;
            this.side2Length = side2Length;
        }
        public void SetLengths(int s1, int s2)
        {
            side1Length = s1;
            side2Length = s2;
        }
    }

    public class Rectangle : Quadralaterals
    {
        public Rectangle(string color, int side1Length, int side2Length) : base(side1Length, side2Length, color)
        {
            
        }

        public int GetArea()
        {
            return side1Length * side2Length;
        }
        public int GetPerimeter()
        {
            return side1Length * 2 + side2Length * 2;
        }
    }

    public class Square : Quadralaterals
    {
        public Square(string color, int side1Length) : base(side1Length, color)
        {
            
        }
        public int GetArea()
        {
            return side1Length * side1Length;
        }
        public int GetPerimeter()
        {
            return side1Length * 4;
        }
    }
}
