using System;
using System.Drawing;

public class Droid : ControllableObject {

  
   public Droid(){
      Picture = new Bitmap("Droid.gif");
	  Voice = new Sound("jad0057a.wav");
   }
   
   
   public override void Move(){
      switch(Direction){
	    case Directions.NORTH : Y -= 10;;
		                        break;
	    case Directions.EAST : X += 10;
		                        break;
		case Directions.SOUTH : Y += 10;
		                        break;
		case Directions.WEST :  X -= 10;
		                        break;
	  }
   }
}