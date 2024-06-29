namespace Flyweight
{
    public class Character : ICharacter
    {
        private char _symbol;
        private string _fontFamily;

        public Character(char symbol, string fontFamily)
        {
            _symbol = symbol;
            _fontFamily = fontFamily;
        }

        public void Display(int fontSize)
        {
            Console.WriteLine($"Character: {_symbol}, Font Family: {_fontFamily}, Font Size: {fontSize}");
        }
    }
}
