namespace RayTracer;

public class Image
{   
    public double aspectRatio;
    public  int imageWidth;
    public int imageHeight;
    
    
    public Image()
    {
        aspectRatio =  16.0 / 9.0;
        imageWidth = 400;
        imageHeight = (int)(imageWidth / aspectRatio);   //height cannot be negative  
        imageHeight = imageHeight < 1 ? 1 : imageHeight;
    }

    public void Render(Camera camera)
    {   
        string filePath = Directory.GetCurrentDirectory();

        using (StreamWriter imageFile = new StreamWriter(Path.Combine(filePath, "image.ppm")))
        {
            double progress = 0.0;
            int countLines = 0;
            int maxLines = imageWidth * imageHeight;

            imageFile.WriteLine($"P3\n{imageWidth} {imageHeight}\n255");

            for (int i = 0; i < imageHeight; i++)
            {
                for (int j = 0; j < imageWidth; j++)
                {             
                    Vector3 pixelCenter = camera.startingPoint + (camera.pixelDeltaU * i) + (camera.pixelDeltaV * j);
                    Vector3 rayDirection = pixelCenter - camera.cameraCenter;

                    Ray ray = new Ray(camera.cameraCenter, rayDirection);

                    Color pixelColor = Color.RayColor(ray);
                    pixelColor.WriteColor(imageFile, pixelColor);

                    progress = countLines++ * 100.0 / maxLines;   
                    Console.Write($"\rCreating file...{progress, 1:F}%");
                }
            }
            Console.WriteLine("\nppm file created.");
        };  
    }
}