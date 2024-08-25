namespace RayTracer;

public class Color : Vector3
{
    public void WriteColor(Color pixelColor)
    {
        double r = pixelColor.X;
        double g = pixelColor.Y;
        double b = pixelColor.Z;

        int ir = (int)(255.999 * r);
        int ig = (int)(255.999 * g);
        int ib = (int)(255.999 * b);

        Console.WriteLine($"{ir} {ig} {ib}");
    }
}