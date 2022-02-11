using System;
using System.Collections.Generic;
using System.Text;

namespace MobileDbPic
{
    internal interface ISQLLite
    {
        string GetDatabasePath(string filename);
    }
}
