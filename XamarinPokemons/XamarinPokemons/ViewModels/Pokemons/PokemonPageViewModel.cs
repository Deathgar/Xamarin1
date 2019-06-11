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
using XamarinPokemons.ViewModels;

namespace XamarinPokemons.ViewModels.Pokemons
{
    public class PokemonPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<PokemonViewModel> Pokemons { get; set; }
        public INavigation Navigation { get; set; }
        PokemonViewModel selectedPokemon;

        public ICommand AddPokemonCommand;

        public ICommand ChangePokemonCommand => new Command(GoOnChangePage);
        public ICommand DeletePokemonCommand;


        public PokemonViewModel SelectedPokemon
        {
            get { return selectedPokemon; }
            set
            {
                if (selectedPokemon != value)
                {
                    var tempPokemonViewModel = value;
                    tempPokemonViewModel.PokemonPageViewModel = this;
                    selectedPokemon = tempPokemonViewModel;
                    OnPropertyChanged(nameof(PokemonPageViewModel));
                    NavigationService.GoOnPokemonPage(new PokemonPage(this));
                }
            }
        }

        public void GoOnPokemonPage(Page pokemonPage)
        {
            NavigationService.GoOnPokemonPage(pokemonPage);
        }

        private void GoOnChangePage()
        {
            NavigationService.GoOnPokemonPage(new ChangePokemonPage(this));
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

//public class PokemonPageViewModel : ContentPage, INotifyPropertyChanged
//{
//    public event PropertyChangedEventHandler PropertyChanged;
   
//    public INavigation Navigation { get; set; }
//    PokemonViewModel selectedPokemon;

//    public ICommand AddPokemonCommand;
//    public ICommand ChangePokemonCommand;
//    public ICommand DeletePokemonCommand;

//    public ICommand GoOnChangePageCommand;

//    public PokemonPageViewModel()
//    {
//        GoOnChangePageCommand = new Command(GoOnChangePage);
//    }

//    public PokemonViewModel SelectedPokemon
//    {
//        get { return selectedPokemon; }
//        set
//        {
//            if (selectedPokemon != value)
//            {
//                var tempPokemonViewModel = value;
//                tempPokemonViewModel.PokemonPageViewModel = this;
//                selectedPokemon = null;
//                OnPropertyChanged(nameof(PokemonPageViewModel));
//                GoOnPokemonPage(tempPokemonViewModel);
//            }
//        }
//    }

//    private async void GoOnPokemonPage(PokemonViewModel tempPokemonViewModel)
//    {
//        await Navigation.PushAsync(new NavigationPage(new PokemonPage(tempPokemonViewModel)));
//    }

//    private async void GoOnChangePage()
//    {
//        await Navigation.PushAsync(new ChangePokemonPage(selectedPokemon));
//    }

//    [NotifyPropertyChangedInvocator]
//    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
//    {
//        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
//    }
//}