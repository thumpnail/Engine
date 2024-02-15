using System;
using Engine.ECS.Components;
namespace Engine.ECS;

public struct GameIdentifier {
    private Guid id;
    public static GameIdentifier empty = new() { id = Guid.Empty };
}