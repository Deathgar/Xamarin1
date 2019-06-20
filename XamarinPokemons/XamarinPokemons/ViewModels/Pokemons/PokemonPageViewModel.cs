using System.Windows.Input;
using Xamarin.Forms;
using XamarinPokemons.Models;
using XamarinPokemons.Services;
using XamarinPokemons.View.PokemonPages;

namespace XamarinPokemons.ViewModels.Pokemons
{
    public class PokemonPageViewModel : BaseViewModel
    {
        public INavigation Navigation { get; set; }

        public ICommand AddPokemonCommand;

        public ICommand ChangePokemonCommand => new Command(GoOnChangePage);
        public ICommand DeletePokemonCommand;

		Pokemon _selectedPokemon;
		public Pokemon SelectedPokemon
		{
			get => _selectedPokemon;
			set
			{
				if (_selectedPokemon != value)
				{
					_selectedPokemon = value;
					OnPropertyChanged(nameof(SelectedPokemon));
					NavigationService.GoOnPokemonPage(new PokemonPage(this));
				}
			}
		}

		//public void GoOnPokemonPage(Page pokemonPage)
  //      {
  //          NavigationService.GoOnPokemonPage(pokemonPage);
  //      }

        private void GoOnChangePage()
        {
            NavigationService.GoOnPokemonPage(new ChangePokemonPage(this));
        }
    }
}