namespace Builder
{
    public interface IComputerBuilder
    {
        IComputerBuilder SetCPU(string cpu);
        IComputerBuilder SetRAM(string ram);
        IComputerBuilder SetGPU(string gpu);
        IComputerBuilder SetStorage(string storage);

        Computer Build();
    }
}
