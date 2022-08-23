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

  public Rectangle FaceA 
  { 
    get 
      { 
        var instance = new Rectangle(Width, Height); 
        return instance;
      }
  }
  public Rectangle FaceB
  { 
    get 
      { 
        var instance = new Rectangle(Height, Depth); 
        return instance;
      }
  }
  public Rectangle FaceC
   { 
    get 
      { 
        var instance = new Rectangle(Width, Depth); 
        return instance;
      }
  }

  public double SurfaceArea
  {
    get {
      double resultFaceA = FaceA.Area * 2;
      double resultFaceB = FaceB.Area * 2;
      double resultFaceC = FaceC.Area * 2;
      return resultFaceA + resultFaceB + resultFaceC;
    }
  }

  public Parallelepiped(double width, double height, double depth) 
  {
    if(width <= 0 || height <= 0 || depth <= 0)
    {
      throw new ArgumentException("All sides must be greater than zero");
    }
    Width = width;
    Height = height;
    Depth = depth;
  }

}
