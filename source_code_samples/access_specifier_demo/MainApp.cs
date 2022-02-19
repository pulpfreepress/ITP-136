public class MainApp {
  public static void Main(){
    BaseClass bc = new BaseClass();
	DerivedClass dc = new DerivedClass();
	
	bc.MethodA();
	// bc.MethodB(); // error will occur
	dc.MethodC();
  }

}