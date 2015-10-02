using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageTracker
{
    interface ILocalDataAccess
    {
        //Store Location of local SQL database
        //Open local SQL connection
        //Read from connection
        //Write to connection
        //Request data updates from WebAccess
        //Respond to requests for data from Display/Client
        PackageLocation GetPackageLocation(string TrackingNumber);
    }
}
