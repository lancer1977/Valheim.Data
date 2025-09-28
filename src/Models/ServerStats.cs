namespace Polyhydra.Valheim.Api.Models;

//"Stats - Online 1 FPS 29.5\nMemory - Mono 104MB, Heap 104MB\nWorld - Day 2, Objects 16901, Dead objects 1481"
public record ServerStats(
    int Players,
    float Fps,
    long MonoMemory,
    long HeapMemory,
    int Day,
    int Objects,
    int DeadObjects
);