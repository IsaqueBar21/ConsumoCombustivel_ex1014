﻿using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int x;
        double y, kmL;

        x = int.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());

        kmL = x / y;

        Console.WriteLine(kmL.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

    }

}