using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    public class StringUtitlity
    {
        public static string SummariseText(string text, int maxLength = 20)
        {


            if (text.Length < maxLength)
            {
                return text;
            }
            else
            {
                var words = text.Split(' ');
                var totlalChars = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);
                    totlalChars += word.Length + 1;
                    if (totlalChars > maxLength)
                    {
                        break;
                    }
                }

                var summary = String.Join(" ", summaryWords) + "...";
                return summary;
            }
        }

    }

}
