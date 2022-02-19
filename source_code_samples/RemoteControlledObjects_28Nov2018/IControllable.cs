using System;
using System.Drawing;

public interface IControllable {
	
	Image Picture {
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
	
	bool IsPenUp {
		get;
	}
	
	void TurnLeft();
	void TurnRight();
	void SetPenUp();
	void SetPenDown();
	void Move();
	void Move(int spaces);
	void Speak();

}