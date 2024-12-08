using System.Threading;

public class ExampleClass
{
    private int _myValue;
    private readonly object _lockObject = new object();

    public int MyValue
    {
        get { return _myValue; }
        set { _myValue = value; }
    }

    public void MyMethod()
    {
        //Some code here
        lock (_lockObject)
        {
            if (MyValue == 0)
            {
                // do something
            }
        }
    }
}