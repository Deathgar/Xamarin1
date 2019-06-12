using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
using XamarinPokemons.ViewModels;

namespace XamarinPokemons.View.Menu
{
    [DesignTimeVisible(true)]
    public partial class MasterPage : ContentPage
    {
        public MasterPage()
        {
            InitializeComponent();
            L.Source = ImageSource.FromFile("Pokeball.png");
            var masterViewModel = new MasterViewModel();
			BindingContext = masterViewModel;
        }
    }
}