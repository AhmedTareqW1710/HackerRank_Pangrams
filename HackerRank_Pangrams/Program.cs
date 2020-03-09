using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the pangrams function below.
    static string pangrams(string s)
    {
        s = s.Replace(" ", "");
        s = s.ToLower();
        if (s.Distinct().Count() == 26)
            return "pangram";
        else
            return "not pangram";
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = pangrams(s);

        Console.WriteLine(result);
        Console.ReadKey();

    }
}
