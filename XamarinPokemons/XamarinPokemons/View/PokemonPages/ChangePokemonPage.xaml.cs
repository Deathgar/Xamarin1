using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPokemons.Models;
using XamarinPokemons.ViewModels.Pokemons;

namespace XamarinPokemons.View.PokemonPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChangePokemonPage : ContentPage
    {
        private PokemonViewModel pokemon;
        private int resultHeight;
        private int resultWeight;
        private bool canChange = true;
        public Command ChangeCommand => new Command(async () => await Change(), () => canChange);

        //public ICommand ChangeCommand
        //{
        //    get { return _baseCommand; }
        //    set { _baseCommand = value; }
        //}

        public ChangePokemonPage(PokemonViewModel pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            BindingContext = this;
            Title = pokemon.PokemonName;
            Name.Text = pokemon.Name;
            Name.TextChanged += TextChange;
            Height.Text = pokemon.Height.ToString();
            Height.TextChanged += TextChange;
            Weight.Text = pokemon.Weight.ToString();
            Weight.TextChanged += TextChange;

            // ChangeCommand = new Command(async () => await Change());

        }

        private async Task Change()
        {
            pokemon.Name = Name.Text;
            pokemon.Height = Int32.Parse(Height.Text);
            pokemon.Weight = Int32.Parse(Weight.Text);
            await Navigation.PopAsync();
        }

        private void TextChange(object sender, TextChangedEventArgs args)
        {
            if (Int32.TryParse(Height.Text, out resultHeight) && Int32.TryParse(Weight.Text, out resultWeight)
                                                              && !String.IsNullOrWhiteSpace(Height.Text) && !String.IsNullOrWhiteSpace(Weight.Text)
                                                              && !String.IsNullOrWhiteSpace(Name.Text))
            {
                canChange = true;
            }
            else
            {
                canChange = false;
            }


            ChangeCommand.ChangeCanExecute();
        }


        private async void Cancel(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}