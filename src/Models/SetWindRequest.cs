namespace Polyhydra.Valheim.Api.Models;
    public record SetWindRequest(float Angle, float Intensity);

    public record ShakeRequest(string SteamId, float Intensity)
    {
        public override string ToString()
        {
            return SteamId + " " + Intensity;
        }
};