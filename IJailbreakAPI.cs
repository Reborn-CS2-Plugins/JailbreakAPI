using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Capabilities;

namespace JailbreakAPI;
public interface IJailbreakAPI
{
    CCSPlayerController? GetWarden();
    void SetWarden(CCSPlayerController warden);
    void RemoveWarden();
    event Action<CCSPlayerController>? OnWardenRemoved;
    event Action<CCSPlayerController>? OnWardenCreated;
}