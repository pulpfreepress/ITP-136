using System;


public class Computer {
	// constants
	private const int READ = 10;
	private const int WRITE = 11;
	private const int LOAD = 20;
	private const int STORE = 21;
	private const int ADD = 30;
	private const int SUB = 31;
	private const int DIV = 32;
	private const int MUL = 33;
	private const int BR = 40;
	private const int BRNEG = 41;
	private const int BRZERO = 42;
	private const int HALT = 43;
	
	// fields
	private int[] memory;
	private int accumulator;
	private int program_counter;
	private bool trace;
	
	
	
	// default constructor
	public Computer(bool trace){
		memory = new int[100];
		accumulator = 0;
		program_counter = 0;
		this.trace = trace;
	}
   
    private void LoadProgram(){
		
		LoadTestProgram();
	}
   
    private void Execute(){
		bool keep_going = true;
		int instruction = 0;
		int opcode = 0;
		int operand = 0;
		
		while(keep_going){
			instruction = memory[program_counter++];
			opcode = instruction/100;
			operand = instruction % 100;
			
			
			
			
			switch(opcode){
				
			  case WRITE : {
				        if(trace) PrintInstruction(opcode, operand);
						 Console.WriteLine("Result: " + memory[operand]);
					     break;
			  }
			  
			  case STORE : {
				       if(trace)PrintInstruction(opcode, operand);
					   memory[operand] = accumulator;
				       break;
			  }
			  
			  case LOAD : {
				        if(trace)PrintInstruction(opcode, operand);
				        accumulator = memory[operand];
				        break;
			  }
			  case READ : {
				        if(trace)PrintInstruction(opcode, operand);
				        try{
							Console.Write("Input: ");
							int input = Int32.Parse(Console.ReadLine());
							memory[operand] = input;
						}catch(Exception){
							memory[operand] = 0;
						}
						
						break;
			  }
				
			  case MUL : {
				        if(trace)PrintInstruction(opcode, operand);
				        accumulator *= memory[operand];
				        break;
			  }
				
				
			  case HALT : {
				       if(trace)PrintInstruction(opcode, operand);
				       keep_going = false;
			           break;
			  }
			  default: {
			       if(trace)PrintInstruction(opcode, operand);
				  
			       break;
			  }
				
			} // end switch
			
			
			
			
		} // end while
		
		 if(trace)DumpMemory();
	}
   
   
    private void LoadTestProgram(){
		Console.WriteLine("Loading program into memory...");
		memory[0] = 1010;
		memory[1] = 1011;
		memory[2] = 2010;
		memory[3] = 3311;
		memory[4] = 2112;
		memory[5] = 1112;
		memory[6] = 4015;
		memory[7] = 4300;
		
		Console.WriteLine("Program loaded...");
	}
   
   private void PrintInstruction(int opcode, int operand){
	   
	  Console.WriteLine("accumulator = " + accumulator); 
	  Console.WriteLine("opcode: {0} operand: {1}", opcode, operand);
	   
   }
   
   
   private void DumpMemory(){
	  for(int i = 0; i<memory.GetLength(0); i++){
        Console.WriteLine("memory[" + i + "] = " + memory[i]);
	  }	  
   }
   
   public void Start(){
	   LoadProgram();
	   Execute();
   }
	
} // end class