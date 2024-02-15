using System;
using System.Text;
using Engine.ECS;
using Engine.ECS.Components;
using Silk.NET.Input;
using Silk.NET.Maths;
using Silk.NET.Windowing;
namespace Engine;

public class Engine {
    private ECSWorld world;
    private IWindow _window;
    private IInputContext input;
    public Engine(string title, Vector2D<int> size) {
        world = new ECSWorld();
        
        WindowOptions options = WindowOptions.Default with {
            Size = size,
            Title = title
        };
        _window = Window.Create(options);
        
        _window.Load += OnLoad;
        _window.Update += OnUpdate;
        _window.Render += OnRender;
        
        _window.Run();
    }
    private void OnLoad() {
        input = _window.CreateInput();
        for (int i = 0; i < input.Keyboards.Count; i++)
            input.Keyboards[i].KeyDown += KeyDown;
        world.OnLoad();
    }
    private void OnUpdate(double deltaTime) {
        world.OnUpdate();
    }
    private void OnRender(double deltaTime) {
        world.OnRender();
        world.OnUi();
    }
    private void KeyDown(IKeyboard keyboard, Key key, int keyCode) {
        if (key == Key.Escape)
            _window.Close();
    }
}