using System.Numerics;

namespace RayTracer;

public class Color
{
    Vector3 vector3;
    public float R { get; set; }
    public float G { get; set; }
    public float B { get; set; }

    public Color()
    {

    }
    public Color(float r, float g, float b)
    {
        vector3 = new Vector3(r, g, b);

        R = vector3.X;
        G = vector3.Y;
        B = vector3.Z;
    }

    public void WriteColor(StreamWriter streamWriter, Color pixelColor)
    {
        int ir = (int)(255.999f * pixelColor.R);
        int ig = (int)(255.999f * pixelColor.G);
        int ib = (int)(255.999f * pixelColor.B);

        streamWriter.WriteLine($"{ir} {ig} {ib}");
    }

    public static Color RayColor(Ray ray)
    {

        if (ray.HitSphere(new Vector3(0, 0, -1.0f), 0.5f, ray))
        {
            return new Color(1.0f, 0, 0);
        }

        Vector3 unitDirection = Vector3.Normalize(ray.Direction);
        float a = 0.5f * unitDirection.Y + 1.0f;
        return new Color (1.0f, 1.0f, 1.0f) * (1.0f - a) + new Color(0.5f, 0.7f, 1.0f) * a;
    }

    public static Color operator *(Color c1, Single a)
    {
        return new Color(c1.R * a, c1.G * a, c1.B * a);
    }

    public static Color operator +(Color c1, Color c2)
    {
        return new Color(c1.R + c2.R, c1.G + c2.G, c1.B + c2.B);
    }
}