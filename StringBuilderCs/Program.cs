﻿using System;
using System.Text;

namespace StringBuilderCs
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder("Hello World");
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            Console.WriteLine("FirstLine: "+builder[0]); 
        }
    }
}
