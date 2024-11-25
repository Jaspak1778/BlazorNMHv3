public class TokenService
{
    private string? accessToken;
    private string? refreshToken;

    // Save both access and refresh tokens
    public void SaveTokens(string access, string refresh)
    {
        accessToken = access;
        refreshToken = refresh;
    }

    // Get the access token
    public string? GetAccessToken()
    {
        return accessToken;
    }

    // Get the refresh token
    public string? GetRefreshToken()
    {
        return refreshToken;
    }

    // Remove both tokens
    public void RemoveTokens()
    {
        accessToken = null;
        refreshToken = null;
    }
}
