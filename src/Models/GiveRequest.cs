namespace Polyhydra.Valheim.Api.Models
{
    public record GiveRequest(string SteamId, string ItemName)
    {
        public int Quality { get; set; } = 1;
        public int Count { get; set; } = 1;
        public int? Variant { get; set; } 
    }
}