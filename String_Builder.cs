using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    class String_Builder
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            Console.WriteLine(builder);

            builder.Replace('-', '+');
            Console.WriteLine(builder);
            builder.Insert(0, new string("im some text"));
            Console.WriteLine(builder);

        }




    }
}
