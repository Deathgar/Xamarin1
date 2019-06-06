using System;
using System.Collections.Generic;
using System.Text;
using XamarinPokemons.Models;

namespace XamarinPokemons.Database
{
    public interface IRepo
    {
        IEnumerable<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        int DeletePokemon(int id);
        int AddPokemon(Pokemon pokemon);
    }
}
