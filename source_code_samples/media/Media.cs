using System;

public abstract class Media : IComparable {

  private string _title;
  
  public Media(string title){
    _title = title;
  }
  
  public Media():this(string.Empty){ }
  
  public string Title {
    get { return _title; }
	set { if(value.Length > 50){
            _title = value.Substring(0, 49);
		  } else {
		    _title = value.Trim();
		  }
	    }
	}
	
	public abstract string Description {
	  get;
	}
	
	public int CompareTo(object obj){
	  return Title.CompareTo(((Media)obj).Title);
	}


} // end Media class 