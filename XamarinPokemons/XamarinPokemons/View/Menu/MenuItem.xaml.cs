using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPokemons.ViewModels.Menu;

namespace XamarinPokemons.View.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuItem : ViewCell
	{
		public MenuItem()
		{
			InitializeComponent ();
			BindingContext = new MenuItemViewModel();
		}
	}
}