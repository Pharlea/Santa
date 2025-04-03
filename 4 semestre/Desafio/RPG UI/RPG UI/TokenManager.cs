using Newtonsoft.Json;
using RPG_UI.Models;
using System;
using System.IO;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;

internal class TokenManager
{
    private const string TokenFilePath = "token.json";

    public void SaveToken(Token token)
    {
        var tokenData = new { AuthToken = token.token };
        var json = JsonConvert.SerializeObject(tokenData, Formatting.Indented);

        File.WriteAllText(TokenFilePath, json);
    }

    public string GetToken()
    {
        if (!File.Exists(TokenFilePath))
            return null;

        var json = File.ReadAllText(TokenFilePath);
        var tokenData = JsonConvert.DeserializeObject<dynamic>(json);

        return tokenData?.AuthToken;
    }

    public string GetUserIdFromToken()
    {
        var token = GetToken();
        if (string.IsNullOrEmpty(token))
            return null;

        var handler = new JwtSecurityTokenHandler();

        try
        {
            // Decodifica o token sem validar a assinatura
            var jwtToken = handler.ReadJwtToken(token);

            // Extrai o campo "certserialnumber"
            var userId = jwtToken.Claims.FirstOrDefault(c => c.Type == "certserialnumber")?.Value;

            return userId;
        }
        catch (Exception)
        {
            return null;
        }
    }
}
