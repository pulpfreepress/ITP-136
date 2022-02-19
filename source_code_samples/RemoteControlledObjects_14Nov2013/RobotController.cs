using System;
using System.Collections.Generic;


public class RobotManager {

  private Floor _its_floor;
  private List<ControllableObject> _its_objects;
  private int _current_object;
  
  
  
  public RobotManager(){
    _its_objects = new List<ControllableObject>();
    _its_floor = new Floor(_its_objects);
	
	
	_its_floor.Show();
  }
  
  
  
  public void AddRat(){
    _its_objects.Add(new Rat());
	_its_floor.Invalidate();
  
  }
  
  public void AddDroid(){
    _its_objects.Add(new Droid());
	_its_floor.Invalidate();
  
  }
  
  
  public void Speak(){
    if(_its_objects.Count > 0){
      _its_objects[_current_object].Speak();
    }
  }
  
  public void Next(){
    if( (_current_object++) >= (_its_objects.Count-1)){
	  _current_object = 0;
	}
  }
  
  
  public void Move(){
    _its_objects[_current_object].Move();
	_its_floor.Invalidate();
  }
  


}