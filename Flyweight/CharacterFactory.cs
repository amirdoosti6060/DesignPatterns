namespace Flyweight
{
    public class CharacterFactory
    {
        private Dictionary<string, ICharacter> _characters = new Dictionary<string, ICharacter>();

        public ICharacter GetCharacter(char symbol, string fontFamily)
        {
            string key = $"{symbol}-{fontFamily}";

            if (!_characters.ContainsKey(key))
            {
                _characters[key] = new Character(symbol, fontFamily);
            }

            return _characters[key];
        }
    }
}
