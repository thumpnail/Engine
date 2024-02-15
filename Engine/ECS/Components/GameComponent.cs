namespace Engine.ECS.Components;

public abstract class GameComponent {
    public GameIdentifier parentId;
    public GameIdentifier id;
    public void OnInit() {}
    public void OnUpdate() {}
    public void OnUi() {}
    public void OnDestroy() {}
    //Gets called everytime a component is created
    protected GameComponent() {
        //TODO: add component to a list somewhere
    }
}