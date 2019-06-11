using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPokemons.Models;
using XamarinPokemons.ViewModels;
using XamarinPokemons.ViewModels.Pokemons;

namespace XamarinPokemons.View.PokemonPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChangePokemonPage : ContentPage
    {
        private PokemonViewModel Pokemon { get; set; }
        private int resultHeight;
        private int resultWeight;
        private bool canChange = true;
        public Command ChangeCommand => new Command( async () => await Change(), () => canChange);

        //public ICommand ChangeCommand
        //{
        //    get { return _baseCommand; }
        //    set { _baseCommand = value; }
        //}

 

        public ChangePokemonPage(PokemonPageViewModel pokemonPageViewModel)
        {
            InitializeComponent();
            this.Pokemon = pokemonPageViewModel.SelectedPokemon;
            BindingContext = this;
            Title = Pokemon.PokemonName;
            NameEntry.Text = Pokemon.Name;
            HeightEntry.Text = Pokemon.Height.ToString();
            WeightEntry.Text = Pokemon.Weight.ToString();

            canChange = false;
            ChangeCommand.ChangeCanExecute();
            // ChangeCommand = new Command(async () => await Change());

        }

        private async Task Change()
        {
            Pokemon.Name = NameEntry.Text;
            Pokemon.Height = Int32.Parse(HeightEntry.Text);
            Pokemon.Weight = Int32.Parse(WeightEntry.Text);
            await Navigation.PopAsync();
        }

        //private void IntChange(object sender, TextChangedEventArgs args)
        //{

        //}

        //private void IntChange(object sender, TextChangedEventArgs args)
        //{
        //    if (Int32.TryParse(Height.Text, out resultHeight) && Int32.TryParse(Weight.Text, out resultWeight))
        //    {
        //        canChange = true;
        //    }
        //    else
        //    {
        //        canChange = false;
        //    }


        //    ((Command)ChangeCommand).ChangeCanExecute();
        //}

        //private void TextChange(object sender, TextChangedEventArgs args)
        //{
        //    if (String.IsNullOrWhiteSpace(Height.Text) && !String.IsNullOrWhiteSpace(Weight.Text) && !String.IsNullOrWhiteSpace(Name.Text))
        //    {
        //        canChange = true;
        //    }
        //    else
        //    {
        //        canChange = false;
        //    }

        //    ((Command)ChangeCommand).ChangeCanExecute();
        //}
        private async void Cancel(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}