using System;
using System.Collections.Generic;
using System.Text;

namespace Codenation.AceleraDev.Services.Extension
{
    public static class CharExtension
    {
        public static bool IsNumber(this char character)
        {
            return char.IsDigit(character);
        }

        public static bool IsEmpty(this char character)
        {
            return char.IsWhiteSpace(character);
        }
    }
}
