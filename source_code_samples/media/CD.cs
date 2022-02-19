using System;

public class CD : RecordedMedia {

  private string _artist;
  
  public CD(string title, string label, string genre, string artist):base(title, label, genre){
  
     _artist = artist;
  }
  
  public CD():this(string.Empty, string.Empty, string.Empty, string.Empty){ }
  
  public string Artist {
    get { return _artist; }
	set { _artist = value; }
  }
  
  public override string Description {
    get { return "CD-> Title: " + Title + " Label: " + Label + " Genre: " + Genre + " Artist " + Artist; }
  }
  
  public override string ToString(){
    return Description;
  }



}