namespace Geometry;
public class Cube : Parallelepiped
{
  public double Side { get; set; }

  public Cube(double side): base(side, side, side) 
  {
    Side = side;
  }

  public Square Face1
  {
    get {
      return new Square(Side);
    }
  }

  public Square Face2
  {
    get {
      return new Square(Side);
    }
  }

  public Square Face3
  {
    get {
      return new Square(Side);
    }
  }
}