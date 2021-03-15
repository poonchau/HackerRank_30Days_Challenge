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
    static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine());

        int remainder;
        string result = "";

        while (n > 0)
        {
            remainder = n % 2;
            n = n / 2;
            result = remainder.ToString() + result;
        }

        Console.Write(result);
        Console.WriteLine();

        int count = 0;
        int result_c = 0;

        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] == '0')
            {
                count = 0;
            }

            else
            {

                count++;
                result_c = Math.Max(result_c, count);
            }


        }

        Console.WriteLine(result_c);
    }
}
