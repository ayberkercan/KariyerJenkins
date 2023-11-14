using EKSystemApp.Application.DTO.Authorization.LDAPAuth;
using EKSystemApp.Application.Features.Authentication.LDAPAuth.Queries;
using EKSystemApp.Application.Interfaces.ILDAPAuthService;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace EKSystemApp.Persistence.LDAPAuth
{
    public class LDAPAuthService : ILDAPAuthService
    {
        private readonly IConfiguration configuration;

        public LDAPAuthService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        /// <summary>
        /// Kullanıcı doğrulama metodudur
        /// </summary>
        /// <returns>AuthApiResponseDto</returns>
        public async Task<AuthApiResponseDto> ValidateUser(CheckUserValidatedQueryRequest request)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            bool TryOnceAgain = false;

            var apiTokenValue = GetApiTokenAsync();

            if (String.IsNullOrEmpty(apiTokenValue.Result)) 
            {
                request.ValidationError = "Turkuvaz Kullanıcı doğrulama servisinden dönüş alınamadı.";
                return new AuthApiResponseDto() { Message = request.ValidationError, Result = apiTokenValue.Result, User = request.Email };
            }
            
            var postParams = new Dictionary<string, string>
            {
                { "api_token", apiTokenValue.Result },
                { "user", request.Email },
                { "password", request.Password }
            };

            var webRequest = await client.PostAsync(configuration.GetSection("TurkuvazAuth").GetSection("AdCheckUserEndPoint").Value, new FormUrlEncodedContent(postParams));

            if (webRequest.IsSuccessStatusCode)
            {
                var response = JsonConvert.DeserializeObject<AuthApiResponseDto>(webRequest.Content.ReadAsStringAsync().Result);

                if (response == null && TryOnceAgain)
                {
                    TryOnceAgain = false;

                    this.ValidateUser(request);
                }
                if (response != null)
                {
                    // Servis "Unauthenticated." response mesajı alıyorsa, api_token expire olmuş demektir. 
                    // Yeni token alınarak tekrar doğrulama işlemi yapılacaktır
                    if (response.Message == "Unauthenticated.")
                    {
                        this.ValidateUser(request);
                    }

                    // Kullanıcı doğrulama işlemi başarılı ise
                    if (response.Result == "success")
                    {
                        return response;
                    }
                    else
                    {
                        // Doğrulama yapılamadı
                        request.ValidationError = response.Message;
                    }
                }
            }

            return new AuthApiResponseDto() { Result = "fail", User = request.Email, Message = request.ValidationError };
        }

        /// <summary>
        /// LDAP doğrulaması için gerekli olan token bilgisinin alınmasını sağlar.
        /// </summary>
        /// <returns>string</returns>
        public async Task<string> GetApiTokenAsync()
        {
            try
            {
                var client = new HttpClient();
                client.DefaultRequestHeaders.Clear();

                var postParams = new Dictionary<string, string>
                {
                    { "api_key", configuration.GetSection("TurkuvazAuth").GetSection("TokenApiKey").Value },
                    { "password", configuration.GetSection("TurkuvazAuth").GetSection("TokenApiPassword").Value }
                };

                var webRequest = await client.PostAsync(configuration.GetSection("TurkuvazAuth").GetSection("TokenEndPoint").Value, new FormUrlEncodedContent(postParams));

                if (webRequest.IsSuccessStatusCode) 
                {
                    var result = JsonConvert.DeserializeObject<TokenApiResponseDto>(webRequest.Content.ReadAsStringAsync().Result);
                    return result != null ? result.Token.ToString() : webRequest.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    return webRequest.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
