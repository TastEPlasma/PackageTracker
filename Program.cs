using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalData Data = new LocalData();
            LocalDisplay Display = new LocalDisplay();

            Console.WriteLine("Input tracking number: ");
            string getme = Console.ReadLine();

            PackageLocation CurrentPackage = Data.GetPackageLocation(getme);

            Display.OutputToConsole(CurrentPackage);

            Console.ReadLine();
        }
    }
}
