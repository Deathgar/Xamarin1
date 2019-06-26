using System.IO;

using Xamarin.Forms;
using XamarinPokemons.Database;
using XamarinPokemons.Droid;
using Environment = System.Environment;

[assembly: Dependency(typeof(AndroidDbPath))]
namespace XamarinPokemons.Droid
{
    class AndroidDbPath : IPath
    {
        public string GetDatabasePath(string filename)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", filename);
        }
    }
}