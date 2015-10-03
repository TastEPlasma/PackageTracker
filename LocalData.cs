using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageTracker
{
    class LocalData : ILocalDataAccess
    {
        private List<PackageLocation> packagelist;
        private PackageLocation packageNotFound;

        public LocalData()
        {
            packagelist = new List<PackageLocation>();
            CreateSampleData();
            
        }


        public PackageLocation GetPackageLocation(string TrackingNumber)
        {

            return GetPackageByTrackingNumber(TrackingNumber);
        }

        private PackageLocation GetPackageByTrackingNumber(string TrackingNumber)
        {
            foreach(PackageLocation locationOfPackage in packagelist)
            {
                if (locationOfPackage.TrackingNumber == TrackingNumber)
                {
                    return locationOfPackage;
                }
            }


            return packageNotFound;
        }


        private void CreateSampleData()
        {
            PackageLocation locpack = new PackageLocation();

            locpack.TrackingNumber = "zxc123";
            locpack.ShippingCompany = "FedEx";
            locpack.Location = "Portland, Or";
            locpack.PackageState = StateOfPackage.Shipped;

            packagelist.Add(locpack);

            locpack.TrackingNumber = "asd456";
            locpack.ShippingCompany = "UPS";
            locpack.Location = "Cleveland, OH";
            locpack.PackageState = StateOfPackage.NotShipped;

            packagelist.Add(locpack);

            packageNotFound.TrackingNumber = "Not Found";
            packageNotFound.ShippingCompany = "Not Found";
            packageNotFound.Location = "Not Found";
            packageNotFound.PackageState = StateOfPackage.NotFound;
        }

    }

    public struct PackageLocation
    {
        public string Location;

        public string TrackingNumber;

        public string ShippingCompany;

        public StateOfPackage PackageState;
    }

    public enum StateOfPackage
    {
        NotFound, NotShipped, Shipped, OutForDelivery, Delivered
    }
}
