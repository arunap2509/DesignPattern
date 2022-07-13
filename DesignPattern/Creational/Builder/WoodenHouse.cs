﻿namespace DesignPattern.Creational.Builder;

public class WoodenHouse: House
{
    public WoodenHouse(): base("Wooden House")
    {
    }

    public void AddParts(string part)
    {
        if (_houseParts.ContainsKey(part))
        {
            _houseParts[part]++;
        }
        else
        {
            _houseParts.Add(part, 1);
        }
    }

    public void Reset()
    {
        _houseParts = new();
    }
}