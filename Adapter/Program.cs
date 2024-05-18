using Adapter;

Console.WriteLine("Adapter Design Pattern (Structural Design Pattern)");

var legacyAdaptee = new LegacyAdaptee();
Console.WriteLine("\nLegacyAdaptee returns a comma seperated items:");
Console.WriteLine(legacyAdaptee.SpecificRequest());
Console.WriteLine("\nBut modern adapter should return an array of strings");
Console.WriteLine("So we use an adapter to adapt the output of Request");


// Create the adapter
var adapter = new Adapter.Adapter(legacyAdaptee);

Console.WriteLine("And here is the result :");
// Use the adapter through the modern interface
string[] result = adapter.Request();
foreach (string s in result)
    Console.WriteLine(s);
