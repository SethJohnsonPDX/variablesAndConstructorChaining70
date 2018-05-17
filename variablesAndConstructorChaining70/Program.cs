using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace variablesAndConstructorChaining70
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a bike model: ");
            string model = Console.ReadLine();
            Console.WriteLine("Enter a bike type: ");
            string type = Console.ReadLine();
            Console.WriteLine("Enter a wheel width: ");
            int ww = Convert.ToInt32(Console.ReadLine());

            Constructors yourBike = new Constructors(ww);
            // This is a const and cannot change
            const string theName = "This is the name that will not change.";
            Console.WriteLine(theName);
            Console.ReadLine();
            File.WriteAllText(@"C:\Users\Student\Desktop\theName.txt", theName);
            // This is a generic var whose type will be interpreted based on the content
            var readBack = File.ReadAllText(@"C:\Users\Student\Desktop\theName.txt");
            Console.WriteLine(readBack);
            Console.WriteLine("Your bike specs are: {0}, {1}, {2}", yourBike.Model, yourBike.Type, yourBike.WW);
            Console.ReadLine();
        }
    }
}
