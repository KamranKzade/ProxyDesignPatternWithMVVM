using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProxyDesignPattern;

public partial class MainWindow : Window
{
    public List<string> Datas { get; set; }

    public MainWindow()
    {
        InitializeComponent();

        Datas = Models.FakeRepo.GetDatas();

       // string str = JsonSerializer.Serialize(Datas);
       // File.WriteAllText("../../../LocalDatabase/LocalDatas.json", str);

    }
}

