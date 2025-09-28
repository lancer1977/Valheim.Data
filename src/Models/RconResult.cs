namespace Polyhydra.Valheim.Api.Models;

public record RestResult<T>(bool Successful, string OutgoingMessage, string Response, T? Result)
    : RestResult(Successful, OutgoingMessage, Response);
