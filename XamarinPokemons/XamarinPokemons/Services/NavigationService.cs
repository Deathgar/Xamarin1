﻿using Xamarin.Forms;
using XamarinPokemons.View.Menu;

namespace XamarinPokemons.Services
{
    public class NavigationService
    {
        public static void Init()
        {

            var master = new MasterPage();

            var detail = new NavigationPage(new View1())
            {
                BarBackgroundColor = Color.DeepSkyBlue
            };

            Application.Current.MainPage = new MasterDetailPage
            {
                Master = master,
                Detail = detail
            };
        }

        public static  void GoOnPokemonPage(Page pokemonPage)
        {
            ((MasterDetailPage)Application.Current.MainPage).Detail.Navigation.PushAsync(pokemonPage);
            ((MasterDetailPage) Application.Current.MainPage).IsPresented = false;
        }
    }
}
