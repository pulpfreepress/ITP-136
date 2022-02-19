using System;
using System.Drawing;

public class Rat : RemoteControlledObject {
	
	
	public Rat():this(new Bitmap("rat.gif"), 0, 0){
		_direction = Directions.EAST;
	}
	
	
	public Rat(Image picture, int x, int y):base(picture, x, y){
      Console.WriteLine("Rat created!");
	}
	
	
	public override void Move(){ 
	   Move(1);
	}
	
	public override void Move(int i){
		switch(this._direction){
		  case Directions.NORTH : this.Y -= i;
		                          break;
		  case Directions.SOUTH : this.Y += i;
		                          break;
		  case Directions.EAST : this.X += i;
		                         break;
		  case Directions.WEST : this.X -= i;
		                         break;
			
			
		}
	}
	
	
}