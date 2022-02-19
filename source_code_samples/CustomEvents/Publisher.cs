using System;

namespace CustomEventExample {
  
  public class Publisher {
          
     public event ElapsedMinuteEventHandler MinuteTick;
     
     
     public Publisher(){
       Console.WriteLine("Publisher Created");
     
     }
     
     
     public void countMinutes(){
     
       int current_minute = DateTime.Now.Minute;
       while(true){
         if(current_minute != DateTime.Now.Minute){ 
            Console.WriteLine("Publisher: {0}", DateTime.Now.Minute);
            onMinuteTick(new MinuteEventArgs(DateTime.Now));
            current_minute = DateTime.Now.Minute;
         }//end if 
       } // end while
     } // end countMinutes method
     
     
     public void onMinuteTick(MinuteEventArgs e){
        if(MinuteTick != null){
           MinuteTick(this, e);
         }
     }// end onMinuteTick method
  
  } // end Publisher class definition

} // end CustomEventExample namespace