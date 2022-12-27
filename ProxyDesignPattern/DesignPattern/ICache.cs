using System.Collections.Generic;

namespace ProxyDesignPattern.DesignPattern;

public interface ICache
{
    List<string> GetValue(string text);
    void SetData(string data);
}
