using System;
using System.Drawing;

public abstract class RemoteControlledObject : IControllable {
	
	protected enum Directions { NORTH, SOUTH, EAST, WEST}
	protected enum PenPositions {UP, DOWN}
	
	protected Point _location;
	protected Image _image;
	protected Directions _direction;
	protected PenPositions _pen_position;
	
	
	public RemoteControlledObject(Image image, int x, int y){
		_image = image;
		_location = new Point(x, y);
		Console.WriteLine("RemoteControlledObject created!");
	}
	
	public int X {
		get { return _location.X; }
		set { _location = new Point(value, _location.Y); }
	}
	
	
	public int Y {
	    get { return _location.Y; }
	    set { _location = new Point(_location.X, value); }
	}
	
	public Point Location {
	   get { return _location; }
	   set { _location = value; }
	}
	
	public Image Picture {
		get { return _image; }
		set { _image = value; }
	}
	
	public void TurnLeft(){
		switch(_direction){
			case Directions.NORTH : _direction = Directions.WEST;
									break;
			case Directions.SOUTH : _direction = Directions.EAST;
			                        break;
			case Directions.EAST :  _direction = Directions.NORTH;
									break;
			case Directions.WEST : _direction = Directions.SOUTH;
									break;
		}
	}
	
	public void TurnRight(){
		switch(_direction){
			case Directions.NORTH : _direction = Directions.EAST;
									break;
			case Directions.SOUTH : _direction = Directions.WEST;
			                        break;
			case Directions.EAST :  _direction = Directions.SOUTH;
									break;
			case Directions.WEST : _direction = Directions.NORTH;
									break;
		}
	}
	
	public void FaceEast(){
		
	}
	
	public void FaceWest(){
		
	}
	
	public void FaceSouth(){
		_direction = Directions.SOUTH;
	}
	
	public void FaceNorth(){
		
	}
		
		
	public void PenUp(){
		_pen_position = PenPositions.UP;
	}
	
	public void PenDown(){
		_pen_position = PenPositions.DOWN;
	}
	
	public abstract void Move();
	
	public abstract void Move(int i);
	
	
	
	
	
} // end class

