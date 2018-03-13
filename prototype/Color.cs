using System;

namespace prototype
{
    public class Color : ColorPrototype
    {
        private int _red;
        private int _blue;
        private int _green;

        public Color(int red, int blue, int green)
        {
            this._red = red;
            this._blue = blue;
            this._green = green;
        }

        // Create a shallow copy
        public override ColorPrototype Clone()
        {
            Console.WriteLine("Cloning color RGB: {0,3},{1,3},{2,3}", _red, _green, _blue);

            return this.MemberwiseClone() as ColorPrototype;
        }
    }
}
