int[] numbers = {2, 4, 6, 8};
System.Console.WriteLine(numbers is [2, 4, 6, 8]);
System.Console.WriteLine(numbers is [2, 4, 6, 7]);

var beatles = new[] {"John", "Paul", "George", "Pete", "Ringo"};

var value = beatles switch
{
    [] => "No hay",
    //string[] b => string.Join(", ", b),
    [_, .. string[] names, _] => string.Join(", ", names)
};

System.Console.WriteLine(value);