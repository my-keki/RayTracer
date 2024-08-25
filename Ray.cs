namespace RayTracer;

public class Ray
{
    public Point3 Origin { get; }
    public Vector3 Direction { get; }

    public Ray()
    {
        
    }

    public Ray(Point3 origin, Vector3 direction)
    {
        Origin = origin;
        Direction = direction;
    }

    public Point3 GetPosition(double t)
    {
        return Origin + (Direction * t);
    }
}