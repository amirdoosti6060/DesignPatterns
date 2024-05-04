namespace Builder
{
    public class GamingDirector
    {
        private IComputerBuilder builder;

        public GamingDirector(IComputerBuilder builder)
        {
            this.builder = builder;
        }

        public Computer Construct()
        {
            builder.SetCPU("Intel Core i7")
                   .SetRAM("16GB DDR4")
                   .SetGPU("NVIDIA GeForce RTX 3080")
                   .SetStorage("1TB SSD");

            return builder.Build();
        }
    }
}
