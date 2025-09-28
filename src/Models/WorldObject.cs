namespace Polyhydra.Valheim.Api.Models
{
    public record WorldObject(
        string Prefab,
        double Distance,
        int Id,
        ulong UserId,
        PositionType Position,
        PositionType Rotation,
        ulong Creator,
        int Health,
        double Support
    );
}