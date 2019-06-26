using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinPokemons.Database
{
    public interface IPath
    {
        string GetDatabasePath(string filename);
    }
}
