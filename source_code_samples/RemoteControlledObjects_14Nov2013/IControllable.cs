using System;
using System.Drawing;

public interface IControllable {

  int X {
     get;
     set;
  }
  
  int Y {
    get;
	set;
  }
  
  Point Position {
    get;
	set;
  }
  
  Image Picture {
    get;
	set;
  }
  
  Sound Voice {
    get;
	set;
  }
  
  Directions Direction {
    get;
	set;
  }
  
  void Move();
  
  void TurnLeft();
  
  void TurnRight();
  
  void Speak();




} // end IControllable