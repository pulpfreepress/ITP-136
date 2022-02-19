using System;
using System.Drawing;

public abstract class ControllableObject : IControllable {
	
	protected enum Directions {NORTH, SOUTH, EAST, WEST }
	protected enum PenPositions {UP, DOWN}
	
	private Point _location;
	
	public ControllableObject(Image picture){
		Picture = picture;
	}
	
	protected Directions Direction {
		get;
		set;
	} = Directions.EAST;
	
	protected PenPositions PenPosition {
		get;
		set;
	} = PenPositions.UP;
	
	protected Point Location {
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
		get;
		set;
	}
	
	public bool IsPenUp {
		get { return (PenPosition == PenPositions.UP) ? true : false; }
	}
	
	public void TurnLeft(){
		switch(Direction){
			case Directions.EAST: Direction = Directions.NORTH;
								  break;
			case Directions.NORTH: Direction = Directions.WEST;
								  break;
		    case Directions.WEST: Direction = Directions.SOUTH;
								  break;
			case Directions.SOUTH: Direction = Directions.EAST;
								  break;
		}
	}
	
	public void TurnRight(){
		switch(Direction){
			case Directions.EAST: Direction = Directions.SOUTH;
								  break;
			case Directions.NORTH: Direction = Directions.EAST;
								  break;
		    case Directions.WEST: Direction = Directions.NORTH;
								  break;
			case Directions.SOUTH: Direction = Directions.WEST;
								  break;
		}
	}
	
	public void SetPenUp(){
		PenPosition = PenPositions.UP;
	}
	
	public void SetPenDown(){
		PenPosition = PenPositions.DOWN;
	}
	
	public abstract void Move();
	public abstract void Move(int spaces);
	public abstract void Speak();
		
	
	
	
	
} // end class