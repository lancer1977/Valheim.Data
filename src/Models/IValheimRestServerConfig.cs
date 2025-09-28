namespace Polyhydra.Valheim.Api.Models
{
    public interface IValheimRestServerConfig
    {
        string ApiKey { get; }
        string BaseUrl { get; }
    }
}