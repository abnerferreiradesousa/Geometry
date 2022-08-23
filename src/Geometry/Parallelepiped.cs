namespace Geometry;
public class Parallelepiped
{
  public double Width { get; set; }
  public double Height { get; set; }
  public double Depth { get; set; }

  public double Volume 
  { 
    get { return Width * Height * Depth; }
  }

  public Rectangle FaceA { 
    get { new Rectangle(Width, Height) }
    set; }
  public Rectangle FaceB { get; set; }
  public Rectangle FaceC { get; set; }
}
