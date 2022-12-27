using ProxyDesignPattern.Models;
using System.Collections.Generic;
using System.Windows;

namespace ProxyDesignPattern.DesignPattern;

public class CacheProxy : ICache
{
    private List<string> CachedConfiguration;
    private List<string> DatabaseConfiguration;



    public CacheProxy()
    {
        CachedConfiguration = FakeRepo.GetAllData();
        DatabaseConfiguration = FakeRepo.GetDataBaseForME();
    }

    public List<string> GetValue(string key)
    {
        var List = new List<string>();

        foreach (var item in DatabaseConfiguration)
        {
            if (List.Count <= 10)
            {
                if (item.StartsWith(key))
                    List.Add(item);
            }
            else
            {
                break;
            }
        }

        if (List.Count == 0)
        {
            DatabaseConfiguration = CachedConfiguration;
            MessageBox.Show("Database Deyisdirildi, artiq Global Database e muraciet olunacaq", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        return List;
    }

    public void SetData(string data)
    {
        CachedConfiguration.Insert(0, data);
    }
}