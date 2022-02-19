using System;
using System.Drawing;

public class Rat : ControllableObject {
	
	public Rat(Image picture):base(picture){ }
	
	public override void Move(){
		Move(1);
	}
	
	public override void Move(int spaces){
		switch(Direction){
			case Directions.NORTH: Y = Y - spaces;
							break;
			case Directions.SOUTH: Y = Y + spaces;
							break;
			case Directions.EAST: X = X + spaces;
							break;
			case Directions.WEST: X = X - spaces;
							break;
		}
	}
	
	//save for later
	public override void Speak(){}
	
}
