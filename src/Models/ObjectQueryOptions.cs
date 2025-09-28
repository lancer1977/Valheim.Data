namespace Polyhydra.Valheim.Api.Models;

public sealed record ObjectQueryOptions(
    string? Prefab = null,
    string? CreatorId = null,
    string? Id = null, 
    string? Tag = null
);