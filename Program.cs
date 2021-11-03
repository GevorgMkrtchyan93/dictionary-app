using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            _Dictionary<int, string> dictionary = new _Dictionary<int, string>();
            dictionary.Add(1, "Ani");
            dictionary.Add(2, "Anna");
            dictionary.Add(3, "Ara");
            dictionary.Add(4, "Azat");

            bool isValid = dictionary.TryGetValue(3, out string value);
            Console.WriteLine($"IsValid:{isValid}");
            Console.WriteLine($"Value={value}");

            Console.ReadLine();

        }
    }
}
