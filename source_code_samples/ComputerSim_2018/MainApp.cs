using System;

public class MainApp {
	
	
	public static void Main(string[] args){
		
		bool trace = false;
		
		if(args.Length > 0){
			try{
				trace = Boolean.Parse(args[0]);
				
			}catch(Exception){
				trace = false;
			}
			
		}
		
		Computer computer = new Computer(trace);
		computer.Start();
	} // end Main
	
} // end class