using System;

public abstract class RecordedMedia : Media {

  private string _label;
  private string _genre;
  
  public RecordedMedia(string title, string label, string genre):base(title){
    _label = label;
	_genre = genre;
  }
  
  public RecordedMedia():this(string.Empty, string.Empty, string.Empty){ }
  
  public string Label {
    get { return _label; }
	set { _label = value; }
  }
  
  public string Genre {
    get { return _genre; }
	set { _genre = value; }
  }


} // end RecordedMedia class