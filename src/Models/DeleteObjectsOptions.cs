namespace Polyhydra.Valheim.Api.Models;

public sealed record DeleteObjectsOptions(
    string? CreatorId = null,
    string? Id = null,
    string? UserId = null,
    string? Tag = null
);