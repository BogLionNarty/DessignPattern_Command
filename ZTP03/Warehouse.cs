using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP03
{
    public class Warehouse
    {

        public static Dictionary<string, int> dict = new()
        {
            { "PC", 5 },
            { "CAR", 12 },
            { "GUITAR", 23 }
        };

        public void AddStuff(string name, int value)
        {
            if (!dict.ContainsKey(name))
            {
                dict.Add(name, value);
            }
            else
            {
                dict[name] += value;
            }
        }
        public void RemoveStuff(string name, int value)
        {
            if (!dict.ContainsKey(name))
            {
                dict.Add(name, value);
            }
            else
            {
                dict[name] -= value;
                if(dict[name] == 0)
                {
                    dict.Remove(name);
                }
            }
           

        }
        public void DisplayWarehouse()
        {
            foreach (var pair in dict)
            {
                Console.WriteLine($"Nazwa: {pair.Key}: Ilość = {pair.Value}");
            }
        }
    }
}


