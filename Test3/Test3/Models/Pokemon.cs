using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using SQLite;

using Xamarin.Forms;

namespace Test3
{
    [Table("Pokemons")]
    public class Pokemon : INotifyPropertyChanged
    {
        public string name;
        public string pokemonName;
        public int height;
        public int weight;

        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
        public string PokemonName
        {
            get { return pokemonName; }
            set
            {
                if (pokemonName != value)
                {
                    pokemonName = value;
                    OnPropertyChanged(nameof(PokemonName));
                }
            }
        }

        public int Height
        {
            get { return height; }
            set
            {
                if (height != value)
                {
                    height = value;
                    OnPropertyChanged(nameof(Height));
                }
            }
        }
        public int Weight
        {
            get { return weight; }
            set
            {
                if (weight != value)
                {
                    weight = value;
                    OnPropertyChanged(nameof(Weight));
                }
            }
        }
        public ImageSource ImageSource { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
