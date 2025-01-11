public class MyClass
{
    public int MyProperty { get; set; } = 0; // Initialize with a default value

    public MyClass() // Initialize in the constructor
    {
        MyProperty = 10; // or any other value
    }

    public void MyMethod()
    {
        int x = MyProperty; //Now it works!
    }
}
