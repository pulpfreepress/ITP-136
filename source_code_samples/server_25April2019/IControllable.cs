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
	
	Point Location {
		get;
		set;
	}
	
	Image Picture {
		get;
		set;
	}
		
	void TurnLeft();
	
	void TurnRight();
	
	void FaceEast();
	
	void FaceSouth();
	
	void FaceNorth();
	
	void FaceWest();
	
	void PenUp();
	
	void PenDown();
	
	void Move();
	
	void Move(int i);
	
	
	
}