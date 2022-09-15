using System.Windows.Input;
using Prism.Commands;
using Prism.Regions;

namespace WpfApp1.ViewModels;

public class MainWindowViewModel
{
    private readonly IRegionManager _regionManager;

    public MainWindowViewModel(IRegionManager regionManager)
    {
        _regionManager = regionManager;
        NavigateCommand = new DelegateCommand<string>(Navigate);
    }

    private void Navigate(string obj)
    {
        _regionManager.RequestNavigate("Main", obj);
    }


    public ICommand NavigateCommand { get; set; }
}