﻿using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace ProxyDesignPattern.Models;

public class FakeRepo
{
    public static List<string> GetAllData()
    {
        return File.ReadAllText("../../../DataBase/Words.txt").Split("\n").ToList();
    }

}