using static TextFileProcessor;
using static MyExtension;
using System.Linq;
using System.Collections.Generic;
using System;

// ---------------------------------------
// COMP 348
// Assignment 4
// Written By: Gabriel Dubois (40209252), Ali Fetanat (40158208), Gabriel D’Alesio(40208868), Liam Daigle(40207583)
// Due June 15, 2022
// ---------------------------------------
class Q4
{
    static List<Shape> shapes = new List<Shape>();
    public static void EachLine(Object o,string input)
    {
        string[] shapeName = input.Split(',');

        // call correct parse method based on first element on line
        if (shapeName[0] == "Circle")
            shapes.Add(MyExtension.Circ_Parse(input));
        else if (shapeName[0] == "Rectangle")
            shapes.Add(MyExtension.Rec_Parse(input));
    }
}
