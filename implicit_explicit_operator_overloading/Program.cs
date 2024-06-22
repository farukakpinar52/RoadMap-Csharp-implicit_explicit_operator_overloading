// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

A instance1 = new B();
A instance2 = (A)new B();

B instance3 = (B)new A();

public class A
{
    //B'nin bir instance'ını A'ya kapalı dönüşüm yaptır. Kapalı dönüşüm yapabildiği için açık dönüşümü de yapabilir.
    public static implicit operator A(B instance)
    {
        return new A();
    };
}
public class B
{
    //A'nın bir instance'ını B'ye açık dönüşüm yaptır. Açık dönüşüm yapılması belirtildiyse kapalı dönüşümü ayrıca belirtmek gerekecektir.
    public static explicit operator B(A instance)
    {
        return new B();
    };
}