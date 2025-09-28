namespace Polyhydra.Valheim.Api.Models;

public sealed record SpawnOptions(
    int? Count = null,
    float? Radius = null,
    int? Level = null,
    PositionType? Rotation = null,
    string? Tag = null,
    bool Tamed = false
);