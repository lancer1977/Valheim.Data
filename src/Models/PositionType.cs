namespace Polyhydra.Valheim.Api.Models
{
    public record struct  PositionType(float X, float Y, float Z, int? ZoneX = null, int? ZoneY = null)
    {
        public override string ToString()
        {
            return $"{X} {Z} {Y}";
        }
    };
}