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
    public partial class PokemonPage : ContentPage
    {
        private Pokemon pokemon;

        public PokemonPage(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            var bindingName = new Binding
            {
                Source = pokemon,
                Path = "Name"
            };


            Title = pokemon.PokemonName;
            Name.SetBinding(Label.TextProperty, bindingName);

            Height.Text = pokemon.Height.ToString();
            Weight.Text = pokemon.Weight.ToString();

        }

        private async void Changing(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChangePokemonPage(pokemon));
        }
    }
}