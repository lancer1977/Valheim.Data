namespace Polyhydra.Valheim.Api.Models
{
    public record HealRequest(PlayerInfo Target, int Amount);
}