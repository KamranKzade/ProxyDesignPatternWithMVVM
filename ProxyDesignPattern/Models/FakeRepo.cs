using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace ProxyDesignPattern.Models;

public class FakeRepo
{
    public static List<string> GetDatas()
    {
        return File.ReadAllText("../../../GlobalDataBase/Words.txt").Split("\n").ToList();
    }
}