using SQLite;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using XamarinPokemons;
using XamarinPokemons.Custom_Elements;
using XamarinPokemons.Models;

namespace XamarinPokemons.Database.DbRepositories
{
    class PokemonRepository
    {
        SQLiteConnection database;
        public PokemonRepository(string filename)
        {
            string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath(filename);
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Pokemon>();
        }

        public IEnumerable<Pokemon> GetPokemons()
        {
            return database.Table<Pokemon>().Select(pokemons => pokemons).ToList();
        }

        public Pokemon GetPokemon(int id)
        {
            return database.Get<Pokemon>(id);
        }

        public int DeletePokemon(int id)
        {
            return database.Delete<Pokemon>(id);
        }

        public int AddPokemon(Pokemon pokemon)
        {
            if (pokemon.Id != 0)
            {
                database.Update(pokemon);
                return pokemon.Id;
            }
            else
            {
                return database.Insert(pokemon);
            }
        }
    }
}
