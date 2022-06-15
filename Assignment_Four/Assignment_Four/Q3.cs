using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


public static class TextFileProcessor
{
    public static event EventHandler<string> LineRead;
 

    public static void Read(string filePath)
    {

        string s = File.ReadAllText(filePath);
        string[] arr = s.Split("\n");
        int line = 1;

        foreach (string str in arr)
        {
            LineRead?.Invoke(null, "Line " + line++ + ":");
            Console.WriteLine(str + "\n");

        }

    }

    public static void TextFileProcessor_LineRead(Object o, string s)
    {
        Console.Write(s + " ");
    }
}

