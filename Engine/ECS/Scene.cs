using System;
using System.Collections.Generic;
namespace Engine.ECS;

public class Scene {
    private GameIdentifier id;
    private List<GameIdentifier> entities = new();
    string name;
}