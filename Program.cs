using RayTracer;

Image image = new();

Camera camera = new(image);

image.Render(camera);

Vector3 vec3 = new Vector3(5, 5, 5);

Ray ray = new Ray(new Point3(), vec3);

Console.WriteLine(ray.GetPosition(1.0));
