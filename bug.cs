public class ExampleClass
{
    private int _myValue;

    public int MyValue
    {
        get { return _myValue; }
        set { _myValue = value; }
    }

    public void MyMethod()
    {
        //Some code here
        if (MyValue == 0)
        {
            // do something
        }
    }
}