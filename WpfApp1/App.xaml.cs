using System.Windows;
using Prism.Ioc;
using WpfApp1.Models;
using WpfApp1.ViewModels;
using WpfApp1.Views;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<GenericView, GenericViewModel<ModelA>>("A");           
            containerRegistry.RegisterForNavigation<GenericView, GenericViewModel<ModelB>>("B");           
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
    }
}