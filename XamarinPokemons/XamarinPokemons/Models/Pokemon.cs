using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using SQLite;

using Xamarin.Forms;
using XamarinPokemons.Annotations;

namespace XamarinPokemons.Models
{
    [Table("Pokemons")]
    public class Pokemon
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Name { get; set; }
        public string PokemonName { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public ImageSource ImageSource { get; set; }

    }
}
