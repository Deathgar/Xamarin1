using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinPokemons.Annotations;
using XamarinPokemons.Models;
using XamarinPokemons.Services;
using XamarinPokemons.View.PokemonPages;

namespace XamarinPokemons.ViewModels.Pokemons
{
    public class PokemonsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Pokemon> Pokemons { get; set; }
        public INavigation Navigation { get; set; }
        Pokemon selectedPokemon;

        public ICommand AddPokemonCommand;

        public ICommand ChangePokemonCommand => new Command(GoOnChangePage);
        public ICommand DeletePokemonCommand;


        #region Properties

        public string Name
        {
            get => selectedPokemon.Name;

            set
            {
                if (value != selectedPokemon.Name)
                {
                    selectedPokemon.Name = value;
                    OnPropertyChanged(nameof(Name));
                    OnPropertyChanged(nameof(SelectedPokemon));
                }
            }
        }

        public string PokemonName
        {
            get => selectedPokemon.PokemonName;

            set
            {
                if (value != selectedPokemon.PokemonName)
                {
                    selectedPokemon.Name = value;
                    OnPropertyChanged(nameof(PokemonName));
                    OnPropertyChanged(nameof(SelectedPokemon));
                }
            }
        }

        public int Weight
        {
            get => selectedPokemon.Weight;

            set
            {
                if (value != selectedPokemon.Weight)
                {
                    selectedPokemon.Weight = value;
                    OnPropertyChanged(nameof(Weight));
                    OnPropertyChanged(nameof(SelectedPokemon));
                }
            }
        }

        public int Height
        {
            get => selectedPokemon.Height;

            set
            {
                if (value != selectedPokemon.Height)
                {
                    selectedPokemon.Height = value;
                    OnPropertyChanged(nameof(Height));
                    OnPropertyChanged(nameof(SelectedPokemon));
                }
            }
        }

        public ImageSource ImageSource
        {
            get => selectedPokemon.ImageSource;

            set
            {
                if (value != selectedPokemon.ImageSource)
                {
                    selectedPokemon.ImageSource = value;
                    OnPropertyChanged(nameof(Height));
                    OnPropertyChanged(nameof(SelectedPokemon));
                }
            }
        }
        #endregion

        public Pokemon SelectedPokemon
        {
            get { return selectedPokemon; }
            set
            {
                if (selectedPokemon != value)
                {
                    selectedPokemon = value;
                    OnPropertyChanged(nameof(SelectedPokemon));

                    GoOnPokemonPage(new PokemonPage(this));

                }
            }
        }

        public void GoOnPokemonPage(Page pokemonPage)
        {
            NavigationService.GoOnPokemonPage(pokemonPage);
        }

        private void GoOnChangePage()
        {
            NavigationService.GoOnPokemonPage(new ChangePokemonPage(selectedPokemon));
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
