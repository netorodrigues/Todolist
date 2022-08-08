using Domain.Exceptions;
using System.Text.RegularExpressions;

namespace Domain.ValueObjects
{
    public sealed class HexColor
    {
        public string Code { get; private set; }
        private readonly string Pattern = "/^#[0-9A-F]{6}$/i";

        public HexColor(string entity, string code)
        {
            if (!Regex.IsMatch(Pattern, code))
            {
                throw new InvalidColorException(entity, code);
            }

            Code = code;
        }
    }
}
