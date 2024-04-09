MyClass obj1 = new MyClass { ValueA = 5, ValueB = 1 };
MyClass obj2 = new MyClass { ValueA = 5, ValueB = 10 };
MyClass obj3 = obj1;

HashSet<MyClass> set = new HashSet<MyClass>() {obj1, obj2, obj3};
System.Console.WriteLine(set.Count);

public class MyClass
{
    public int ValueA { get; set; }
    public int ValueB { get; set; }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        MyClass other = (MyClass)obj;
        return this.ValueA == other.ValueA && this.ValueB == other.ValueB;
    }

    public override int GetHashCode()
    {
        return ValueA.GetHashCode() ^ ValueB.GetHashCode();
    }
}
