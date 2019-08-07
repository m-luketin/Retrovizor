using System;
namespace Retrovizor.Domain.Classes
{
    public class Token
    {
        public Token(string access, string refresh)
        {
            Access = access;
            Refresh = refresh;
        }

        public string Access { get; set; }
        public string Refresh { get; set; }
    }
}
