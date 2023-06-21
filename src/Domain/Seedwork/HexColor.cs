using Domain.Exceptions;
using System.Text.RegularExpressions;

namespace Domain.Seedwork
{
    public record HexColor<T>
    {
        public string Code { get; private set; }
        private readonly string Pattern = "^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$";

        public HexColor(string code)
        {
            if (!Regex.IsMatch(code, Pattern))
            {
                throw new InvalidColorException(nameof(T), code);
            }

            Code = code;
        }
    }
}
