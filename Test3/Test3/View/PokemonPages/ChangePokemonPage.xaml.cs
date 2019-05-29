using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChangePokemonPage : ContentPage
    {
        private Pokemon pokemon;
        private int resultHeight;
        private int resultWeight;
        public ICommand ChangeCommand;

        //public ICommand ChangeCommand
        //{
        //    get { return _baseCommand; }
        //    set { _baseCommand = value; }
        //}

        public ChangePokemonPage(Pokemon pokemon)
        {
            InitializeComponent();
            BindingContext = this;
            this.pokemon = pokemon;

            Title = pokemon.PokemonName;
            Name.Text = pokemon.Name;
            Height.Text = pokemon.Height.ToString();
            Weight.Text = pokemon.Weight.ToString();
            ChangeCommand = new Command(() => DisplayAlert("dwad", "Dawd", "dada"));
        }

        private async void Change()
        {
            pokemon.Name = Name.Text;
            pokemon.Height = resultHeight;
            pokemon.Weight = resultWeight;
            await Navigation.PopAsync();
        }

        private bool CanChanged()
        {
            DisplayAlert("dwda", "dawdaw", "cacw");
            if (Int32.TryParse(Height.Text, out resultHeight) && Int32.TryParse(Weight.Text, out resultWeight) 
                                                              && !String.IsNullOrWhiteSpace(Height.Text) && !String.IsNullOrWhiteSpace(Weight.Text) 
                                                              && !String.IsNullOrWhiteSpace(Name.Text))
            {
                return true;
            }

            return false;
        }

        private async void Cancel(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}