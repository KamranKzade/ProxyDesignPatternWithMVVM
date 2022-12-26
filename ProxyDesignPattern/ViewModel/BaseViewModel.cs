using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ProxyDesignPattern.ViewModel;

public class BaseViewModel
{
    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string name = null!)
    {
        PropertyChangedEventHandler handler = PropertyChanged!;
        if (handler != null)
        {
            handler(this, new PropertyChangedEventArgs(name));
        }
    }

}
