using Catel.Services;
using CatelTest.Uwp.Ui.ViewModels;

namespace CatelTest.Uwp.Ui.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AnotherView : Catel.Windows.Controls.Page
    {
        public AnotherView()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            (Catel.IoC.ServiceLocator.Default.ResolveType(typeof(NavigationService)) as NavigationService).Navigate(typeof(PersonViewModel));
        }
    }
}
