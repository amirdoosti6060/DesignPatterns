using Flyweight;

Console.WriteLine("Flyweight Design Pattern (Structural Design Pattern)\n");

CharacterFactory factory = new CharacterFactory();

// Create characters with shared intrinsic state
ICharacter a1 = factory.GetCharacter('a', "Arial");
ICharacter a2 = factory.GetCharacter('a', "Arial");
ICharacter b1 = factory.GetCharacter('b', "Verdana");

// Display characters with extrinsic state
a1.Display(12);
a2.Display(14);
b1.Display(16);
