using Builder;

Console.WriteLine("Builder Design Pattern (Creational Design Pattern)");

// Create a computer using builder
var builder = new ComputerBuilder()
                    .SetRAM("4GB DDR4")
                    .SetStorage("1TB SSD");

Computer homeComputer = builder.Build();
Console.WriteLine("\n------ Home Computer -----");
homeComputer.PrintSpec();

// Create a computer user Director
var builder2 = new ComputerBuilder();
var gamingDirector = new GamingDirector(builder2);
var gamingComputer = gamingDirector.Construct();
Console.WriteLine("\n------ Gaming Computer -----");
gamingComputer.PrintSpec();

