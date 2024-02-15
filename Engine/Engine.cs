using System;
using System.Text;
using Engine.ECS;
using Engine.ECS.Components;
namespace Engine;

public class Engine {
    private ECSWorld world;
    public Engine() {
        Console.WriteLine("Hello from Engine!");
    }
    public void Run() {
        world = new();
        world.Run();
    }
}