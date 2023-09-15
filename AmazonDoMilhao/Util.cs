using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AmazonDoMilhao;
internal class Util
{
    public static string RemoveAccent(string input)
    {
        input = input
            .Replace("\xBA", "") // º
            .Replace("\xB0", "") // º outro formato
            .Replace("Nº", "N")
            .Replace("NÂ°", "N")
            .Replace("N\xC2", "N")
            .Replace("n\xC2", "n")
            .Replace("nÂ°", "N")
            .Replace("nº", "n")
            .Replace(",", "");

        return new string(input
            .Normalize(System.Text.NormalizationForm.FormD)
            .ToCharArray()
            .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
            .ToArray());
    }
}
