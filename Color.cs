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
}