using System.Text.Json;
using System.Text.Json.Serialization;

namespace MauiApp3.Models
{
    public class TokenService
    {
        private readonly HttpClient _httpClient;
        private string? _csrfToken;

        private const string CsrfUri = "https://djangorestapiv3.azurewebsites.net/api/csrf/";

        public TokenService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetCsrfTokenAsync()
        {
            if (string.IsNullOrEmpty(_csrfToken))
            {
                // Haetaan CSRF-token vain, jos sitä ei vielä ole
                var response = await _httpClient.GetAsync(CsrfUri);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var csrfData = JsonSerializer.Deserialize<CsrfTokenResponse>(json);

                    if (csrfData?.CsrfToken != null)
                    {
                        _csrfToken = csrfData.CsrfToken;
                    }
                    else
                    {
                        // Käsitellään token jos null
                        throw new InvalidOperationException("CSRF token not found in the response.");
                    }
                }
                else
                {
                    // tokenin virheen käsittely
                    throw new HttpRequestException("Failed to retrieve CSRF token.");
                }
            }

            return _csrfToken ?? throw new InvalidOperationException("CSRF token is null.");
        }

        private class CsrfTokenResponse
        {
            [JsonPropertyName("csrfToken")] // Vastattava JSON avainta
            public string? CsrfToken { get; set; }
        }
    }
}
