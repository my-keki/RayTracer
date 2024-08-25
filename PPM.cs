namespace RayTracer;

public class PPM
{
    public const int imageWidth = 256;
    public const int imageHeight = 256;

    public PPM()
    {

    }

    public static void Init()
    {
        string filePath = Directory.GetCurrentDirectory();

        //auto invoke dispose() to free resources
        using (StreamWriter imageFile = new StreamWriter(Path.Combine(filePath, "image.ppm")))
        {
            imageFile.WriteLine($"P3\n{imageWidth} {imageHeight}\n255");

            for (int i = 0; i < imageHeight; i++)
            {
                for (int j = 0; j < imageWidth; j++)
                {
                    double r = (double)i / (imageWidth - 1);
                    double g = (double)j / (imageHeight - 1);
                    double b = 0.0;

                    int ir = (int)(255.999 * r);
                    int ig = (int)(255.999 * g);
                    int ib = (int)(255.999 * b);

                    imageFile.WriteLine($"{ir} {ig} {ib}");
                }
            }
            Console.WriteLine("ppm file created.");
        };  
    }
}