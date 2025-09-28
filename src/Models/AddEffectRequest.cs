namespace Polyhydra.Valheim.Api.Models
{
    public record AddEffectRequest(string SteamId, string PowerName)
    {
        public override string ToString()
        {
            return SteamId + " " + PowerName;
        }
    };
}