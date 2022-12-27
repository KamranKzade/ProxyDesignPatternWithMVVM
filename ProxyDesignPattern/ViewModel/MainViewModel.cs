using ProxyDesignPattern.Commands;
using System.Collections.Generic;
using System.Windows.Controls;
using ProxyDesignPattern.DesignPattern;

namespace ProxyDesignPattern.ViewModel;


public class MainViewModel : BaseViewModel
{
    public List<string> AllData { get; set; }
    public List<string>? AlreadySearched { get; set; }

    public RelayCommand SearchCommand { get; set; }
    public RelayCommand SelectionChangedCommand { get; set; }


    public MainViewModel()
    {
        ICache cache = new CacheProxy();

        AllData = new List<string>();
        AlreadySearched = new List<string>();


        SearchCommand = new RelayCommand((o) =>
        {
            var textBox = o as TextBox;

            var listbox = ((((textBox!.Parent as Grid)!.Parent as Grid)!.Children[0] as Grid)!.Children[1] as ScrollViewer)!.Content as ListBox;
            var data = textBox.Text;
            cache.SetData(data);

            listbox!.ItemsSource = string.Empty;
            AlreadySearched.Add(data);
            listbox!.ItemsSource = AlreadySearched;

        });


        SelectionChangedCommand = new RelayCommand((o) =>
        {
            var Listbox = o as ListBox;
            var text = (((Listbox!.Parent as Grid)!.Children[1] as Grid)!.Children[0] as TextBox)!.Text;

            if (text != string.Empty)
            {
                AllData = cache.GetValue(text);
                Listbox!.ItemsSource = null;
                Listbox!.ItemsSource = AllData;
            }
            else
                Listbox!.ItemsSource = null;

        });
    }
}
