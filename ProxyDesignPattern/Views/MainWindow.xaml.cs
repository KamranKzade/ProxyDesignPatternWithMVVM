using ProxyDesignPattern.ViewModel;
using System.Windows;

namespace ProxyDesignPattern;

public partial class MainWindow : Window
{

    public MainWindow()
    {
        InitializeComponent();
        var viewModel = new MainViewModel();
        this.DataContext = viewModel;
    }

}