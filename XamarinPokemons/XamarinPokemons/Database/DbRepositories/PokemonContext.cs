using SQLite;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Xamarin.Forms;
using XamarinPokemons;
using XamarinPokemons.Custom_Elements;
using XamarinPokemons.Models;

namespace XamarinPokemons.Database.DbRepositories
{
    class PokemonContext : DbContext
    {
        private string _databasePath;

        public DbSet<Pokemon> Pokemons { get; set; }

        public PokemonContext(string databasePath)
        {
            _databasePath = databasePath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_databasePath}");
        }
    }
}
