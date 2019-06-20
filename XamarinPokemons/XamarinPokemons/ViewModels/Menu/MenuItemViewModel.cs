using System.Windows.Input;
using Xamarin.Forms;
using XamarinPokemons.Services;
using XamarinPokemons.View.PokemonPages;

namespace XamarinPokemons.ViewModels.Menu
{
	public class MenuItemViewModel : BaseViewModel
	{
		private string _name;
		public string Name
		{
			get => _name;
			set
			{
				if (_name == value) return;
				_name = value;
				OnPropertyChanged(nameof(Name));
			}
		}

		private string _pokemonName;
		public string PokemonName
		{
			get => _pokemonName;
			set
			{
				if (_pokemonName == value) return;
				_pokemonName = value;
				OnPropertyChanged(nameof(PokemonName));
			}
		}

		private int _height;
		public int Height
		{
			get => _height;
			set
			{
				if (_height == value) return;
				_height = value;
				OnPropertyChanged(nameof(Height));
			}
		}

		private int _weight;
		public int Weight
		{
			get => _weight;
			set
			{
				if (_weight == value) return;
				_weight = value;
				OnPropertyChanged(nameof(Weight));
			}
		}

		private ImageSource _imageSource;
		public ImageSource ImageSource
		{
			get => _imageSource;
			set
			{
				if (_imageSource == value) return;
				_imageSource = value;
				OnPropertyChanged(nameof(ImageSource));
			}
		}

		public bool IsValid => !string.IsNullOrEmpty(Name.Trim()) ||
		                       !string.IsNullOrEmpty(PokemonName.Trim()) ||
		                       int.TryParse(Weight + "", out _) ||
		                       int.TryParse(Height + "", out _);

        private void GoOnChangePage()
        {
            NavigationService.GoOnPokemonPage(new ChangePokemonPage(this));
        }

    }
}
