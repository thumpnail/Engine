using System;
using System.Collections.Generic;
using System.ComponentModel;
using Engine.ECS.Components;
namespace Engine.ECS;

//ECS World
public class ECSWorld {
    //Dictionary in hope to improve performance
    private List<Entity> _entities = new();
    private List<AGameComponent> _components = new();
    public Scene activeScene;

    private bool gameRunning = false;
    
    public ECSWorld() {
        _entities = new();
        _components = new();
    }
    public void AddEntity(Entity entity) {
        _entities.Add(entity);
    }
    public Entity GetEntity(GameIdentifier entityId) {
        return _entities.Find(x => x.id.Equals(entityId)) ?? Entity.empty;
    }
    public void AddComponent(GameIdentifier entityId, AGameComponent component) {
        component.parentId = entityId;
        _components.Add(component);
    }
    
    public void OnLoad() {
        //for each component in scene .OnLoad()
    }
    public void OnUpdate() {
        //for each component in scene .OnUpdate()
    }
    public void OnRender() {
        //for each component in scene .OnRender()
    }
    public void OnUi() {
        //for each component in scene .OnUi()
    }
}