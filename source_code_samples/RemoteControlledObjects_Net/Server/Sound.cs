using System;
using System.Media;


public class Sound {

  private SoundPlayer _itsPlayer;
  
  
  public String Voice {
    get { return _itsPlayer.SoundLocation; }
	set { _itsPlayer.SoundLocation = value; }
  }

  
  // constructors
  public Sound(string path_to_sound){
    _itsPlayer = new SoundPlayer(path_to_sound);
  }
  
  
  // methods
  public void Speak(){
     _itsPlayer.Play();  

  }

}