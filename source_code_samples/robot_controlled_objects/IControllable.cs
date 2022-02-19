using System;
using System.Drawing;

public interface IControllable {

  Point Location {
    get;
    set;
  }
  
  int X {
    get;
    set;
  }
  
  int Y {
    get; 
    set;
  }
  
  void Move();
  
  void Move(int spaces);
  
  void TurnLeft();
  
  void TurnRight();
  
  void SetPenUp();
  
  void SetPenDown();
  
  Image Picture {
    get;
    set;
  }

  
  
}