using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageTracker
{
    interface IDisplay
    {
        //Outputs data in client viewable form
        void OutputToConsole(PackageLocation CurrentPackage);
    }
}
