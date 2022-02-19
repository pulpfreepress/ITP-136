using System;
using System.Drawing;

public abstract class ControllableObject : IControllable {

 
 
 
 // Fields
 private Point _itsPosition;
 private Directions _itsDirection;
 private Image _itsPicture;
 private Sound _itsVoice;
 
 
 
 
 // Properties
 public int X {
   get { return _itsPosition.X; }
   set { _itsPosition.X = value; }
 }
 
 public int Y {
   get { return _itsPosition.Y; }
   set { _itsPosition.Y = value; }
 }
 
 public Point Position {
    get { return _itsPosition; }
	set { _itsPosition = value; }
 
 }
 
 public Image Picture {
   get { return _itsPicture; }
   set { _itsPicture = value; }
 
 }
 
 public Sound Voice {
   get { return _itsVoice; }
   set { _itsVoice = value; }
 }
 
 public Directions Direction {
  get { return _itsDirection; }
  set { _itsDirection = value; }
 }
 
 // constructors
 
 public ControllableObject(){
   _itsDirection = Directions.EAST;
   _itsPosition.X = 0;
   _itsPosition.Y = 0;
   
 }
 
 
 
 // methods

 public void TurnLeft() {
    switch(_itsDirection){
	  case Directions.NORTH : _itsDirection = Directions.WEST;
	       break;
	  case Directions.WEST : _itsDirection = Directions.SOUTH;
	       break;
	  case Directions.SOUTH : _itsDirection = Directions.EAST;
	       break;
	  case Directions.EAST : _itsDirection = Directions.NORTH;
	       break;
	}
 }
 
 
 public void TurnRight() {
    switch(_itsDirection){
	  case Directions.NORTH : _itsDirection = Directions.EAST;
	       break;
	  case Directions.WEST : _itsDirection = Directions.NORTH;
	       break;
	  case Directions.SOUTH : _itsDirection = Directions.WEST;
	       break;
	  case Directions.EAST : _itsDirection = Directions.SOUTH;
	       break;
	}
 }
 
 // abstract methods
 public abstract void Move();
 
 public virtual void Speak(){
    Voice.Speak();
 }



} // end ControllableObject