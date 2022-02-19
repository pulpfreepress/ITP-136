using System;

public class TestClassTwo : MarshalByRefObject, ITest {

  private string _text;

  public string Text {
    get { return _text; }
    set { 
       _text = value;
       Console.WriteLine("Property changed --> " + _text);
       }
  }
  
  public TestClassTwo():this("This is the new default text message!"){}

  public TestClassTwo(string s){
    _text = s;
  }
  
}