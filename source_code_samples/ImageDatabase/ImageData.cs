using System;
using System.Drawing;

[Serializable]
public class ImageData {
  private Image  _image;
  private string _description;
  private string _name;
  
  public ImageData(Image image, string name, string description){
    _image = image;
	_name = name;
	_description = description;
  }
  
  public ImageData():this(null, String.Empty, String.Empty){ }
  
  public Image Image {
    get { return _image; }
	set { _image = value; }
  }
  
  public string Name {
    get { return _name; }
	set { _name = value; }
  }
  
  public string Description {
    get { return _description; }
	set { _description = value; }
  }
}