using System;

namespace PrototypeRealWorld
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var colormanager = new ColorManager
            {
                ["red"] = new Color(255, 0, 0),
                ["green"] = new Color(0, 255, 0),
                ["blue"] = new Color(0, 0, 255),
                ["angry"] = new Color(255, 54, 0),
                ["peace"] = new Color(128, 211, 128),
                ["flame"] = new Color(211, 34, 20)
            };

            // Initialize with standard colors

            // User adds personalized colors

            // User clones selected colors
            var color1 = colormanager["red"].Clone() as Color;
            var color2 = colormanager["peace"].Clone() as Color;
            var color3 = colormanager["flame"].Clone() as Color;

            // Wait for user
            Console.ReadKey();
        }
    }
    /// <summary>
    /// The 'Prototype' abstract class
    /// </summary>
    internal abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }
    internal class Color:ColorPrototype
    {
        private int _red;
        private int _green;
        private int _blue;

        // Constructor
        public Color(int red, int green, int blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
        }

        // Create a shallow copy
        public override ColorPrototype Clone()
        {
            Console.WriteLine(
              "Cloning color RGB: {0,3},{1,3},{2,3}",
              _red, _green, _blue);

            return this.MemberwiseClone() as ColorPrototype;
        }
    }

}
