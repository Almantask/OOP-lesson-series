using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_guide
{
    public static class MagicConverter
    {
        private static string _magicString = "Magic";
        public static string Convert(string text)
        {
            if (text.ToLower().Contains(_magicString))
                return text;
            else
                return _magicString + " " + text;
        }
    }
}
