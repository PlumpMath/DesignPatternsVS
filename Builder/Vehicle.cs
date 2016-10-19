using System;
using System.Collections.Generic;

namespace Builder
{
    /// <summary>
    /// The 'Product' class
    /// </summary>
    public class Vehicle
    {
        private string _v;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();
        public Vehicle(string v)
        {
            _v = v;
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", _v);
            Console.WriteLine(" Frame : {0}", _parts["frame"]);
            Console.WriteLine(" Engine : {0}", _parts["engine"]);
            Console.WriteLine(" #Wheels: {0}", _parts["wheels"]);
            Console.WriteLine(" #Doors : {0}", _parts["doors"]);
        }

        public string this[string frame]
        {
            get { return _parts[frame]; }
            set { _parts[frame] = value; }
        }
    }
}