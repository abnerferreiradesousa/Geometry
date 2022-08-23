﻿namespace Geometry;
public class Rectangle
{
  public double Width { get; set; }
  public double Height { get; set; }

  public double Area 
  {
    get { return Width * Height; }
  }

  public double Perimeter 
  {
    get { return (Width * 2) + (Height * 2); }
  }

  public Rectangle(double width, double height) 
  {
    if(width < 0 || height < 0) 
    {
      throw new ArgumentException("All sides must be greater than zero");
    }
    Width = width;
    Height = height;
  }
}