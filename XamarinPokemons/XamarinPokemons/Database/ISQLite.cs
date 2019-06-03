using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinPokemons.Database
{
    public interface ISQLite
    {
        string GetDatabasePath(string filename);
    }
}
