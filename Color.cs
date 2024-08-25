namespace RayTracer;

public class Color : Vector3
{
    public Color(double r, double g, double b) : base(r, g, b)
    {
        
    }

    public void WriteColor(StreamWriter streamWriter, Color pixelColor)
    {
        double r = pixelColor.X;
        double g = pixelColor.Y;
        double b = pixelColor.Z;

        int ir = (int)(255.999 * r);
        int ig = (int)(255.999 * g);
        int ib = (int)(255.999 * b);

        streamWriter.WriteLine($"{ir} {ig} {ib}");
    }
}