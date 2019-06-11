using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;
using XamarinPokemons.Annotations;
using XamarinPokemons.Models;
using XamarinPokemons.ViewModels.Pokemons;

namespace XamarinPokemons.ViewModels
{
    public class PokemonViewModel : INotifyPropertyChanged
    {
        public Pokemon Pokemon { get; set; }

        private PokemonPageViewModel pokemonPageViewModel;
        public event PropertyChangedEventHandler PropertyChanged;

        public PokemonViewModel()
        {
            Pokemon = new Pokemon();
        }

        public PokemonPageViewModel PokemonPageViewModel
        {
            get { return pokemonPageViewModel; }
            set
            {
                if (pokemonPageViewModel != value)
                {
                    pokemonPageViewModel = value;
                    OnPropertyChanged(nameof(PokemonPageViewModel));
                }
            }
        }

        public string Name
        {
            get { return Pokemon.Name; }
            set
            {
                if (Pokemon.Name != value)
                {
                    Pokemon.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
        public string PokemonName
        {
            get { return Pokemon.PokemonName; }
            set
            {
                if (Pokemon.PokemonName != value)
                {
                    Pokemon.PokemonName = value;
                    OnPropertyChanged(nameof(PokemonName));
                }
            }
        }

        public int Height
        {
            get { return Pokemon.Height; }
            set
            {
                if (Pokemon.Height != value)
                {
                    Pokemon.Height = value;
                    OnPropertyChanged(nameof(Height));
                }
            }
        }
        public int Weight
        {
            get { return Pokemon.Weight; }
            set
            {
                if (Pokemon.Weight != value)
                {
                    Pokemon.Weight = value;
                    OnPropertyChanged(nameof(Weight));
                }
            }
        }

        public ImageSource ImageSource
        {
            get { return Pokemon.ImageSource; }
            set
            {
                if (Pokemon.ImageSource != value)
                {
                    Pokemon.ImageSource = value;
                    OnPropertyChanged(nameof(ImageSource));
                }
            }
        }

        public bool IsValid
        {
            get
            {
                int res;

                return ((!string.IsNullOrEmpty(Name.Trim())) ||
                        (!string.IsNullOrEmpty(PokemonName.Trim())) ||
                        (Int32.TryParse(Weight + "", out res)) ||
                        (Int32.TryParse(Height + "", out res)));
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
