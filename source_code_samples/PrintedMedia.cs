using System;

public abstract class PrintedMedia : Media {

  private string _isbn;
  private string _publisher;
  
  public PrintedMedia(string title, string isbn, string publisher):base(title){
    _isbn = isbn;
	_publisher = publisher;
  }
  
  public PrintedMedia():this(string.Empty, string.Empty, string.Empty){ }
  
  public string ISBN {
    get { return _isbn; }
	set { _isbn = value; }
  }
  
  public string Publisher {
    get { return _publisher; }
	set { _publisher = value; }
  }


} // end PrintedMedia class