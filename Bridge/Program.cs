using Bridge;

Console.WriteLine("Bridge Design Pattern (Structural Design Pattern)\n");

IDevice tv = new TV();
RemoteControl tvRemote = new RemoteControl(tv);
tvRemote.TogglePower(); // Output: TV is enabled.
tvRemote.VolumeUp(); // Output: Volume is now 10

Console.WriteLine();
IDevice radio = new Radio();
AdvancedRemoteControl radioRemote = new AdvancedRemoteControl(radio);
radioRemote.TogglePower(); // Output: Radio is enabled.
radioRemote.VolumeUp(); // Output: Volume is now 10
radioRemote.Mute(); // Output: Volume is muted.
