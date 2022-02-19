using System;

namespace CustomEventExample {

   
   public class MinuteEventArgs : EventArgs {
     private DateTime date_time;
     
     public MinuteEventArgs(DateTime date_time){
       this.date_time = date_time;
     }
     
     public int Minute {
       get { return date_time.Minute; }
     
     }
   }
} 