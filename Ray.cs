using System.Numerics;

namespace RayTracer;

public class Ray
{
    public Vector3 Origin { get; }
    public Vector3 Direction { get; }

    public Ray()
    {
        
    }

    public Ray(Vector3 origin, Vector3 direction)
    {
        Origin = origin;
        Direction = direction;
    }

    public Vector3 GetPosition(float t)
    {
        return Origin + Vector3.Multiply(Direction, t);
    }

    public float HitSphere(Vector3 center, float radius, Ray ray)
    {
        Vector3 oc = center - ray.Origin;
        var a = Vector3.Dot(ray.Direction, ray.Direction);
        var b = -2.0f * Vector3.Dot(ray.Direction, oc);
        var c = Vector3.Dot(oc, oc) - (radius * radius);
        var discriminant = (b * b) - (a * c * 4);
        
        return (float)(discriminant < 0.0f ? -1.0f : (-b - Math.Sqrt(discriminant)) / (2.0f * a)); 
    }
}