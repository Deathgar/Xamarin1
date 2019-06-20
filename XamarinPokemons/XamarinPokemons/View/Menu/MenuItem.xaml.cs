using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPokemons.ViewModels.Menu;

namespace XamarinPokemons.View.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuItem
    {
        public StackLayout Layout1
        {
            get { return Layout; }
        }
        private MenuItemViewModel menuItemViewModel;
		public MenuItem(string pokemonName, string name, int height, int weight, ImageSource imageSource )
		{
			InitializeComponent ();
            menuItemViewModel = new MenuItemViewModel
            {
                PokemonName = pokemonName,
                Name = name,
                Height = height,
                Weight = weight,
                ImageSource = imageSource
            };
            
            BindingContext = menuItemViewModel;
        }
	}
}