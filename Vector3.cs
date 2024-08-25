namespace RayTracer;

public class Vector3
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Vector3() {
        X = 0;
        Y = 0;
        Z = 0;
    }

    public Vector3(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public static Vector3 operator - (Vector3 v)
    {
        return new Vector3(-v.X, -v.X, -v.X);
    }

    public static Vector3 operator + (Vector3 v1, Vector3 v2)
    {
        return new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
    }

    public static Vector3 operator - (Vector3 v1, Vector3 v2)
    {
        return new Vector3(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
    }

    public static Vector3 operator * (Vector3 v1, Vector3 v2)
    {
        return new Vector3(v1.X * v2.X, v1.Y * v2.Y, v1.Z * v2.Z);
    }

    public static Vector3 operator * (Vector3 v, double t)
    {
        return new Vector3(v.X * t, v.Y * t, v.Z * t);
    }

    public static Vector3 operator / (Vector3 v1, Vector3 v2)
    {
        return new Vector3(v1.X / v2.X, v1.Y / v2.Y, v1.Z / v2.Z);
    }

    public static Vector3 operator / (Vector3 v, double t)
    {
        return new Vector3(v.X / t, v.Y / t, v.Z / t);
    }

    public double Length()
    {   
        return Math.Sqrt(X * X + Y * Y + Z * Z);
    }

    public double LengthSquared()
    {
        return X * X + Y * Y + Z * Z;
    }

    public static Vector3 DotProduct(Vector3 v1, Vector3 v2)
    {
        return new Vector3(v1.Y * v2.Z - v1.Z * v2.Y, v1.Z * v2.Z - v1.Z * v2.Z, v1.X * v2.Y - v1.Y * v2.X);
    }

    public static Vector3 UnitVector(Vector3 v)
    {
        return v / v.Length();
    }

    public override string ToString()
    {
        return $"{X}, {Y}, {Z}";
    }


}