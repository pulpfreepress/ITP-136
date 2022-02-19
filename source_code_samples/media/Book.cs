using System;

public class Book : PrintedMedia {

  private string _author;
  
  public Book(string author,
              string isbn, 
			  string publisher,
			  string title):base(title, isbn, publisher){
	_author = author; 
  }
  
  public Book():this(string.Empty, string.Empty, string.Empty, string.Empty){ }
  
  public string Author {
    get { return _author; }
	set { _author = value; }
  
  }
  
  public override string Description {
    get { return "Book->Title: " + Title + " Author: " + Author + " ISBN: " + ISBN 
	                             + " Publisher: " + Publisher; }							 
  }
  
  public override string ToString(){
    return Description;
  }
  
  

} // end Book Class