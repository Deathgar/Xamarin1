using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinPokemons.Custom_Elements.CustomButtons;
using XamarinPokemons.Services;
using XamarinPokemons.View.PokemonPages;
using XamarinPokemons.ViewModels;
using XamarinPokemons.ViewModels.Menu;
using XamarinPokemons.ViewModels.Pokemons;

namespace XamarinPokemons.View.Menu
{
    [DesignTimeVisible(true)]
    public partial class MasterPage : ContentPage
    {
        //public ICommand TapCommand => new Command( 
        //    execute:(MenuItemViewModel arg) =>
        //    {
        //        OnTap(arg);
        //    });
        private int k;
        public MasterPage()
        {
            InitializeComponent();

            L.Source = ImageSource.FromFile("Pokeball.png");
            var masterViewModel = new MasterViewModel();
            BindingContext = masterViewModel;

            listDetail.ItemsSource = masterViewModel.Pokemons;
            //foreach (var pokemon in masterViewModel.Pokemons)
            //{
            //    //var menuItem = new MenuItem(pokemon.PokemonName, pokemon.Name, pokemon.Height, pokemon.Weight,
            //    //    pokemon.ImageSource);

            //    var tempButton = new PokemonButtom();
            //    tempButton.Text = pokemon.Name;
            //    tempButton.Pokemon = pokemon;
            //    tempButton.SetBinding(Button.CommandProperty, new Binding());
            //    //menuItem.Layout1.GestureRecognizers.Add(tapGestureRecognizer);
            //    MenuList.Children.Add(tempButton) ;
            //}
        }

        //private void OnTap(MenuItemViewModel s)
        //{
        //    NavigationService.GoOnPokemonPage(new PokemonPage(s));
        //}
        public async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var pokemon = e.Item as MenuItemViewModel;
            NavigationService.GoOnPokemonPage(new PokemonPage(pokemon));
        }
    }
}
