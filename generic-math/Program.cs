// See https://aka.ms/new-console-template for more information
using System.Numerics;

var val1 = Suma<int>(2,3);
var val2 = Suma<double>(30,40);
System.Console.WriteLine(val1);
System.Console.WriteLine(val2);


static T Suma<T>(T a, T b) where T : INumber<T>
{
    return a + b;
}