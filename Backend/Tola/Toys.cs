using System;
using System.Text.Json;

namespace Backend. Tola
{
    public class Toys
    {
        public string Color = "Red";
        public int Legs = 2;
        private int _batteries; 
        public Toys(string color, int legs)
        {
            Color = color;
            Legs = legs;
            
        }
        public int AddBatteries(int batteries)
        {
            _batteries = batteries;
            return _batteries;
        }
            ~Toys() { 
        
        }
        public string Bag()
        {
           //in place of database query
            return $"Color: {Color}, Legs: {Legs}, Time: {DateTime.Now}";
        }
    }


}
