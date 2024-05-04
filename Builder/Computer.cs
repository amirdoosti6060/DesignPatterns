namespace Builder
{
    public class Computer
    {
        public string CPU { get; set; } = "Intel Core i3";
        public string RAM { get; set; } = "2GB DDR4";
        public string GPU { get; set; } = "Intel Arc A380";
        public string Storage { get; set; } = "256GB";

        public void PrintSpec()
        {
            Console.WriteLine("Computer Spec:");
            Console.WriteLine($"CPU: {CPU}");
            Console.WriteLine($"RAM: {RAM}");
            Console.WriteLine($"GPU: {GPU}");
            Console.WriteLine($"Storage: {Storage}");
        }
    }
}
