using System;
using System.Drawing;

public class ControllableObject : IControllable {

    public enum Direction {NORTH, SOUTH, EAST, WEST};
    public enum PenPosition { UP, DOWN};
    
    
    private Point _location;
    private Image _image;
    private Direction _direction;
    private PenPosition _penPosition;
    
    
    public ControllableObject(){
      _location = new Point(0, 0);
      _direction = Direction.EAST;
      _penPosition = PenPosition.UP;
    }
    
    public Point Location {
      get { return _location; }
      set { _location = value; }
    }
    
    public int X {
      get { return _location.X; }
      set { _location.X = value; }
    }
    
    public int Y {
      get { return _location.Y; }
      set { _location.Y = value; }
    }
    
    public Image Picture {
      get { return _image; }
      set { _image = value; }
    }
    
    public void TurnLeft(){
      switch(_direction){
        case Direction.EAST: _direction = Direction.NORTH;
                             break;
        case Direction.NORTH: _direction = Direction.WEST;
                             break;
        case Direction.WEST: _direction = Direction.SOUTH;
                             break;
        case Direction.SOUTH: _direction = Direction.EAST;
                             break;
        
      }
    }
    
    public void TurnRight(){
      switch(_direction){
        case Direction.EAST: _direction = Direction.SOUTH;
                             break;
        case Direction.NORTH: _direction = Direction.EAST;
                             break;
        case Direction.WEST: _direction = Direction.NORTH;
                             break;
        case Direction.SOUTH: _direction = Direction.WEST;
                             break;
        
      }
    }
    
    public void SetPenUp(){
      _penPosition = PenPosition.UP;
    }
    
    public void SetPenDown(){
      _penPosition = PenPosition.DOWN;
    }
    
    
    public void Move(){
      this.Move(1);
    }
    
    
    public void Move(int spaces){
    switch(_direction){
        case Direction.EAST: _location.X += spaces;
                             break;
        case Direction.NORTH: _location.Y -= spaces;
                             break;
        case Direction.WEST: _location.X -= spaces;
                             break;
        case Direction.SOUTH: _location.Y += spaces;
                              break;
      }
    
    }
    

}