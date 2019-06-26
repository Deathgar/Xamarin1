using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPokemons.Database;
using XamarinPokemons.Database.DbRepositories;
using XamarinPokemons.Models;
using XamarinPokemons.Services;

namespace XamarinPokemons
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "Pokemons.db";


        public App()
        {
            InitializeComponent();

            string dbPath = DependencyService.Get<IPath>().GetDatabasePath(DATABASE_NAME);
            using (var db = new PokemonContext(dbPath))
            {
                // Создаем бд, если она отсутствует
                db.Database.EnsureCreated();
                if (db.Pokemons.Count() == 0)
                {
                    db.Pokemons.Add(new Pokemon{ PokemonName = "Pikachu", Name = "Pika", Height = 30, Weight = 12, ImageSource = ImageSource.FromFile("Pikachu.png") });
                    db.Pokemons.Add(new Pokemon { PokemonName = "Charizard", Name = "Char", Height = 170, Weight = 90, ImageSource = "Charizard.png" });
                    db.Pokemons.Add(new Pokemon { PokemonName = "Squirtle", Name = "Squirtle", Height = 50, Weight = 9, ImageSource = ImageSource.FromFile("Squirtle.png") });
                    db.SaveChanges();
                }
            }
           

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
