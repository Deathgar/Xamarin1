using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChangePokemonPage : ContentPage
    {
        private Pokemon pokemon;

        public ChangePokemonPage(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;

            Title = pokemon.PokemonName;
            Name.Text = pokemon.Name;
            Height.Text = pokemon.Height.ToString();
            Weight.Text = pokemon.Weight.ToString();

        }

        private async void Change(object sender, EventArgs e)
        {
            int resultHeight;
            int resultWeight;
            if (Int32.TryParse(Height.Text, out resultHeight) && Int32.TryParse(Weight.Text, out resultWeight))
            {
                pokemon.Name = Name.Text;
                pokemon.Height = resultHeight;
                pokemon.Weight = resultWeight;
                await Navigation.PopAsync();
            }
         

        }

        private async void Cancel(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}