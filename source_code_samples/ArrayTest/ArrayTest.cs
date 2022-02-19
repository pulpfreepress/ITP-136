/****************************************************
   Some code to help you better understand how
   to create and manipulate arrays.
****************************************************/

using System;
using System.Windows.Forms;

public class ArrayTest {

 
  // value type arrays
  private     int[] int_array = null;  // a single-dimensional array of ints
  private bool[] boolean_array = null; // a single-dimensional array of boolean
  
  // reference type arrays
  private Object[] object_array = null;
  
  
  // a square two-dimensional array
  private int[,] int_2d_square_array = null;
  
  // a ragged two-dimensional array
  private int[][] int_2d_ragged_array = null;



  /**************************************
     Constructor 
  **************************************/
  public ArrayTest(){
    createSingleDimensionalArrays(); 
    initializeArrays();
    printArrayContents();
    printArrayTypeNames();
    Console.WriteLine("-----------------------------------------");
    createMultiDimensionalArrays();
    printMultiDimensionalArrays();
  }



  /***************************************
    Creates single dimensional arrays
  ****************************************/
  public void createSingleDimensionalArrays(){
  
    Console.WriteLine("Creating the array of ints...");
         
    int_array = new int[5]; 
         
    Console.WriteLine("Creating the array of booleans...");
         
    boolean_array = new bool[5];
         
    Console.WriteLine("Creating the array of Objects...");
          
    object_array = new Button[5];
  }
  
  
  public void createMultiDimensionalArrays(){
    Console.WriteLine("Creating square array!");
    int_2d_square_array = new int[5,7];
    
    Console.WriteLine("Creating ragged array!");
    int_2d_ragged_array = new int[5][];
    int_2d_ragged_array[0] = new int[5];
    int_2d_ragged_array[1] = new int[2];
    int_2d_ragged_array[2] = new int[9];
    int_2d_ragged_array[3] = new int[20];
    int_2d_ragged_array[4] = new int[4];
    
  
  }
  
  public void printMultiDimensionalArrays(){
     for(int i = 0; i<int_2d_square_array.GetLength(0); i++){
       for(int j = 0; j<int_2d_square_array.GetLength(1); j++){
          Console.Write(int_2d_square_array[i,j]);
       }
      Console.WriteLine();
     }
     
     Console.WriteLine("-----------------------------------------");
     
     for(int i = 0; i<int_2d_ragged_array.Length; i++){
       for(int j = 0; j<int_2d_ragged_array[i].Length; j++){
         Console.Write(int_2d_ragged_array[i][j]);
       }
     Console.WriteLine();
     }
  
  }
  
  
  public void printArrayContents(){
  
    for(int i = 0; i<int_array.Length; i++){
       Console.WriteLine("Integer array element {0} contains : {1}", i+1, int_array[i]);
    }
    
    for(int i = 0; i<boolean_array.Length; i++){
       Console.WriteLine("Boolean array element {0} contains : {1}", i+1, boolean_array[i]);
    }
    
    for(int i = 0; i<object_array.Length; i++){
       Console.WriteLine("Object array element {0} contains : {1}", i+1, object_array[i].ToString());
    }
  
  }
  
  
  public void initializeArrays(){
    for(int i = 0; i<int_array.Length; i++){
       int_array[i] = i+1;
    }
    
    for(int i = 0; i<boolean_array.Length; i++){
       boolean_array[i] = true;
    }
    
    for(int i = 0; i<object_array.Length; i++){
       object_array[i] = new Button();
       ((Button)object_array[i]).Text = "Button " + i;
    }
    
  
  }
  
  
  public void printArrayTypeNames(){
    Console.WriteLine(int_array.ToString());
    Console.WriteLine(boolean_array.ToString());
    Console.WriteLine(object_array.ToString());
    
  
  }




  public static void Main(String[] args){
     new ArrayTest();
  }


} // end class definition