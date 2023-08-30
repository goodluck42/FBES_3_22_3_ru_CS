struct MyStruct
{
    public int Value { get; set; }
    public MyClass MyClass { get; set; } // pointer in stack, data in heap
}