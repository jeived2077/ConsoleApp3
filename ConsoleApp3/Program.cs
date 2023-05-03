// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
class Circle
{
    int x;
    int y;
    int radius;
    public Circle()
    {
        x = 0;
        y = 0;
        radius = 0;
    }
    public Circle(int radius)
    {
        x = 0; y = 0;
        this.radius = radius;
    }
    public Circle(int x,int y)
    {
      this.x = x;
        this.y = y;
        radius = 0;
    }
    public Circle(int radius,int x,int y) { 
    this.radius = radius;
        this.x = x;
        this.y = y; 
    }
}
