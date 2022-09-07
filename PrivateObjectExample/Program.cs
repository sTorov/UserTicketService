using PrivateObjectExample;
using System.Reflection;
using System.Text;

/*
 * Приватные члены класса не наследуются
 */

class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Type typeMyClass = typeof(MyClass);
        Type typeBaseClass = typeof(BaseClass);
        BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic;

        var myClassMethods = typeMyClass.GetMethods(bindingFlags);
        var baseClassMethods = typeBaseClass.GetMethods(bindingFlags);

        Console.WriteLine("MyClass:\n");
        foreach(var method in myClassMethods)
            Console.WriteLine(method.Name);

        Console.WriteLine();

        Console.WriteLine("BaseClass:\n");
        foreach (var method in baseClassMethods)
            Console.WriteLine(method.Name);

        Console.ReadKey();
    }
}