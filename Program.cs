using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "this is a ridiculously long piece of text which noone will ever read";
            var summary = StringUtitlity.SummariseText(sentence);
            Console.WriteLine(summary);

        }

        
    }


}