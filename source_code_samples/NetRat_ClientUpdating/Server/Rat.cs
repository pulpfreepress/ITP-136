using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace RatSpace {

  [Serializable]
  public class Rat{

    private Point _position;
    private Image _image;
  
    public Rat(String image_name){
     _image = new Bitmap(image_name);
     _position = new Point(20, 20);
    }
  
    public int X{
      get{ return _position.X; }
      set{ _position.X = value; }
    }
    
    public int Y{
      get{ return _position.Y; }
      set{ _position.Y = value; }
    }
    
    public Image Image{
     get{return _image; }
    }
    
    public Point Point{
      get{ return _position; }
    }


 } // end class Rat
} // end namespace


