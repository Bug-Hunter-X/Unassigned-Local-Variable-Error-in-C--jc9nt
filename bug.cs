public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that hasn't been initialized
        int x = MyProperty; //Error: Use of unassigned local variable 'MyProperty'
    }
}