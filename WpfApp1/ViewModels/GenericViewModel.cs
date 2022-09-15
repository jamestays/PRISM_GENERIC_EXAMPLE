namespace WpfApp1.ViewModels;

public class GenericViewModel<T>
{
    public string Name => typeof(T).Name;
}