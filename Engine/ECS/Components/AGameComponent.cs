namespace Engine.ECS.Components;

public abstract class AGameComponent {
    public GameIdentifier parentId;
    public GameIdentifier id;
    public virtual void OnLoad() {}
    public virtual void OnUpdate(double deltaTime) {}
    public virtual void OnRender(double deltaTime) {}
    public virtual void OnUi() {}
    public virtual void OnDestroy() {}
    //Gets called everytime a component is created
    protected AGameComponent() {
        //TODO: add component to a list somewhere so we know which components exist and which not
    }
}