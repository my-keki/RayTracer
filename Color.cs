namespace RayTracer;

public class Color : Vector3
{
    public double R {get => X; set => X = value;}
    public double G {get => Y; set => Y = value;}
    public double B {get => Z; set => Z = value;}

    public Color() : base()
    {

    }
    public Color(double r, double g, double b) : base(r, g, b)
    {
       
    }

    public void WriteColor(StreamWriter streamWriter, Color pixelColor)
    {
        int ir = (int)(255.999 * pixelColor.R);
        int ig = (int)(255.999 * pixelColor.G);
        int ib = (int)(255.999 * pixelColor.B);

        streamWriter.WriteLine($"{ir} {ig} {ib}");
    }

    public static Color RayColor(Ray ray)
    {
        Vector3 unitDirection = UnitVector(ray.Direction);
        double a = 0.5 * unitDirection.Y + 1.0;
        return new Color (1.0, 1.0, 1.0) * (1.0 - a) + new Color(0.5, 0.7, 1.0) * a;
    }

    public static Color operator *(Color c1, double a)
    {
        return new Color(c1.R * a, c1.G * a, c1.B * a);
    }

    public static Color operator +(Color c1, Color c2)
    {
        return new Color(c1.R + c2.R, c1.G + c2.G, c1.B + c2.B);
    }
}