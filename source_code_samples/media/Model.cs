using System;
using System.Collections.Generic;


public class Model {

  private List<Media> _mediaList = null;
  
  public Model(){
    _mediaList = new List<Media>();
  }
  
  public List<Media> MediaList {
    get { return _mediaList; }
  }
  
  public int AddMedia(Media media){
    _mediaList.Add(media);
	return _mediaList.Count;
  }
  
  public void SortMediaList(){
    _mediaList.Sort();
  }
  
  


}