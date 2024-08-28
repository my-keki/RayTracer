using System.Numerics;

namespace RayTracer;
public class Camera
{
    public float focalLength;
    public float viewportWidth;
    public float viewportHeight;
    public Vector3 cameraCenter;
    public Vector3 viewportUpperLeft;
    public Vector3 viewportU;
    public Vector3 viewportV;
    public Vector3 pixelDeltaU;
    public Vector3 pixelDeltaV;
    public Vector3 startingPoint;

    public Camera(Image image)
    {   
        focalLength = 1.0f;
        viewportHeight = 2.0f;
        viewportWidth = viewportHeight * ((float)image.imageWidth / image.imageHeight);
        cameraCenter = new Vector3(0, 0, 0);

        viewportU = new Vector3(viewportWidth, 0, 0);
        viewportV = new Vector3(0, -viewportHeight, 0);

        pixelDeltaU = viewportU / image.imageWidth;
        pixelDeltaV = viewportV / image.imageHeight;

        viewportUpperLeft = cameraCenter - new Vector3(0, 0, focalLength) - viewportU / 2 - viewportV / 2;
        startingPoint = viewportUpperLeft + (pixelDeltaU + pixelDeltaV) * 0.5f;
    }
}