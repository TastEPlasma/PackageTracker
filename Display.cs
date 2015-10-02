using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageTracker
{
    public class LocalDisplay : IDisplay
    {
        public void OutputToConsole(PackageLocation CurrentPackage)
        {
            Console.WriteLine("Location: {0}", CurrentPackage.Location);
            Console.WriteLine("ShippingCompany: {0}", CurrentPackage.ShippingCompany);
            Console.WriteLine("CurrentState: {0}", CurrentPackage.PackageState);
            Console.WriteLine("Tracking Number: {0}", CurrentPackage.TrackingNumber);
        }
    }
}
