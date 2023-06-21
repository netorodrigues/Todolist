using Domain.Exceptions;
using System.Text.RegularExpressions;

namespace Domain.Seedwork
{
    public sealed record HexColor
    {
        public string Code { get; private set; }
        private readonly string Pattern = "^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$";

        public HexColor(string entity, string code)
        {
            if (!Regex.IsMatch(code, Pattern))
            {
                throw new InvalidColorException(entity, code);
            }

            Code = code;
        }
    }
}
