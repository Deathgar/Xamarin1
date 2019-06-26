using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using XamarinPokemons.Database.DbRepositories;
using XamarinPokemons.Models;

namespace XamarinPokemons.Database
{
    public class CRUDPokemon : I_CRUD
    {
        private PokemonContext db;

        public CRUDPokemon()
        {
            db = new PokemonContext(DependencyService.Get<IPath>().GetDatabasePath(App.DATABASE_NAME)); 
        }


        public void Save(object obj)
        {
            var pokemon = obj as Pokemon;
            if (!String.IsNullOrEmpty(pokemon.Name))
            {
                if (pokemon.Id == 0)
                    db.Pokemons.Add(pokemon);
                else
                {
                    db.Pokemons.Update(pokemon);
                }

                db.SaveChanges();
            }
        }

        public void Delete(object obj)
        {
            var pokemon = obj as Pokemon;

            db.Pokemons.Remove(pokemon);
            db.SaveChanges();
        }

        public object Get(int id)
        {
            return db.Pokemons.Select(x => x).Where(x => x.Id == id);
        }

        public IEnumerable<object> GetAll()
        {
            return db.Pokemons.ToList();
        }
    }
}
