using System;

namespace CustomEventExample {

  public class Subscriber {
  
    private Publisher publisher;
    
    public Subscriber(Publisher publisher){
      this.publisher = publisher;
      subscribeToPublisher();
      Console.WriteLine("Subscriber Created");
    }
    
    public void subscribeToPublisher(){
       publisher.MinuteTick += new ElapsedMinuteEventHandler(minuteTickHandler);
    }
    
    public void minuteTickHandler(Object sender, MinuteEventArgs e){
      Console.WriteLine("Subscriber Handler Method: {0}", e.Minute);
    
    }
   } // end Subscriber class definition
} // end CustomEventExample namespace