namespace EKSystemApp.Application.Tools
{
    public class JwtTokenDefaults
    {
        public const string ValidAudience = "http://localhost";
        public const string ValidIssuer = "http://localhost";
        public const string Key = "Korkma-sonmez-bu-safaklarda-yuzen-al-sancak";
        public const int Expire = 5;
    }
    public class JwtAuthenticationDefaults
    {
        public const string AuthenticationScheme = "JWT";
        public const string HeaderName = "Authorization";
        public const string BearerPrefix = "Bearer";
    }
}
