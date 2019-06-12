using System.Collections.ObjectModel;
using Xamarin.Forms;
using XamarinPokemons.ViewModels.Menu;
using System.Windows.Input;

namespace XamarinPokemons.ViewModels
{
    class MasterViewModel: BaseViewModel
	{
		private ObservableCollection<MenuItemViewModel> _pokemons;
		public ObservableCollection<MenuItemViewModel> Pokemons
		{
			get => _pokemons;
			set
			{
				if (_pokemons == value) return;
				_pokemons = value;
				OnPropertyChanged(nameof(Pokemons));
			}
		}
		public MasterViewModel()
        {
	        Pokemons = new ObservableCollection<MenuItemViewModel> { new MenuItemViewModel { PokemonName = "Pikachu", Name = "Pika", Height = 30, Weight = 12, ImageSource = ImageSource.FromFile("Pikachu.png")},
                new MenuItemViewModel { PokemonName = "Charizard", Name = "Char", Height = 170, Weight = 90, ImageSource = "Charizard.png"},
                new MenuItemViewModel { PokemonName = "Squirtle", Name = "Squirtle", Height = 50, Weight = 9, ImageSource = ImageSource.FromFile("Squirtle.png")}};
        }

		
	}
}
