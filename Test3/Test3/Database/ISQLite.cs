using System;
using System.Collections.Generic;
using System.Text;

namespace Test3.Custom_Elements
{
    public interface ISQLite
    {
        string GetDatabasePath(string filename);
    }
}
