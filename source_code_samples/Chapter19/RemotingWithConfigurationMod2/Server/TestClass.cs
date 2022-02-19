using System;

public class TestClass : MarshalByRefObject, ITest {

  private string _text;

  public string Text {
    get { return _text; }
    set { 
       _text = value;
       Console.WriteLine("Property changed --> " + _text);
       }
  }
  
  public TestClass():this("This is the new default text message!"){}

  public TestClass(string s){
    _text = s;
  }
  
}