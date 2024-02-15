using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Engine.Common;
using Engine.ECS.Components;
namespace Engine.ECS;

public class Entity {
    public string name;
    public GameIdentifier parentId;
    public GameIdentifier id;
    public Transform transform;
    private Entity() {
        transform = Transform.empty;
        id = GameIdentifier.empty;
        parentId = GameIdentifier.empty;
        name = "";
    }
    public Entity(string name) {
        this.name = name;
        id = new();
    }
    public Entity(string name, params AGameComponent[] components) : this(name) {
        //this.components = components.ToList();
    }
    public static Entity empty => new();
}