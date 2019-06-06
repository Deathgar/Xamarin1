using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPokemons.Database;
using XamarinPokemons.Database.DbRepositories;
using XamarinPokemons.Services;

namespace XamarinPokemons
{
    public partial class App : Application
    {
        private const string DATABASE_NAME = "pokemons.db";
        private static IRepo pokemonRepo;

        public static IRepo PokemonRepo
        {
            get
            {
                if (pokemonRepo == null)
                {
                    pokemonRepo = new PokemonRepository(DATABASE_NAME);
                }
                return pokemonRepo;
            }
        }

        public App()
        {
            InitializeComponent();

            NavigationService.Init();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
