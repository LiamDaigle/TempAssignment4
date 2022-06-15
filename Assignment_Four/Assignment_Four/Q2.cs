using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


static class MyExtension
{
    public static void Print(this Shape name)
    {
        Console.WriteLine(name.ToString());
    }

    public static Rectangle Rec_Parse(this string str)
    {
        string[] words = str.Split(',');
        if (words.Length != 3 || !(words[0] == "Rectangle"))
            return new Rectangle();
        else
        {
            return new Rectangle(Double.Parse(words[1]), Double.Parse(words[2]));
        }
    }

    public static Circle Circ_Parse(this string str)
    {
        string[] words = str.Split(',');
        if (words.Length != 2 || !(words[0] == "Circle"))
            return new Circle();
        else
        {
            return new Circle(Double.Parse(words[1]));
        }
    }

}
