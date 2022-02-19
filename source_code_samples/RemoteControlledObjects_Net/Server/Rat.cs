using System;
using System.Drawing;

public class Rat : ControllableObject {

  
   public Rat(){
      Picture = new Bitmap("Rat.gif");
	  Voice = new Sound("jad0051a.wav");
   }
   
   
   public override void Move(){
      switch(Direction){
	    case Directions.NORTH : Y--;
		                        break;
	    case Directions.EAST : X++;
		                        break;
		case Directions.SOUTH : Y++;
		                        break;
		case Directions.WEST :  X--;
		                        break;
	  }
   }
}