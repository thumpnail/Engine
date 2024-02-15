namespace Engine.Common;

public struct Transform {
    public static Transform empty = new() {
        position = Silk.NET.Maths.Vector3D<double>.Zero,
        scale = Silk.NET.Maths.Vector3D<double>.Zero,
        rotation = Silk.NET.Maths.Quaternion<double>.Identity
    };
    public Silk.NET.Maths.Vector3D<double> position;
    public Silk.NET.Maths.Vector3D<double> scale;
    public Silk.NET.Maths.Quaternion<double> rotation;
}