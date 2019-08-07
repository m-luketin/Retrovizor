using System;

namespace Retrovizor.Domain.Helpers
{
    internal class JwtSecurityToken
    {
        private string issuer;
        private object audience;
        private byte[] secret;
        private DateTime expires;
        private object ;

        public JwtSecurityToken(string issuer, object audience, byte[] secret, DateTime expires, object )
        {
            this.issuer = issuer;
            this.audience = audience;
            this.secret = secret;
            this.expires = expires;
            this. = ;
        }
    }
}