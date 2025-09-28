namespace Polyhydra.Valheim.Api.Models
{
    public record SpawnRequest(string PrefabName, PositionType Position, SpawnOptions? Options = null);
}