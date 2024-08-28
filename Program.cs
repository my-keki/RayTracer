using RayTracer;

Image image = new();

Camera camera = new(image);

image.Render(camera);

