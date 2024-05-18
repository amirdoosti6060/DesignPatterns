namespace Adapter
{
    public class Adapter: IModernTarget
    {
        private readonly LegacyAdaptee _legacyAdaptee;

        public Adapter(LegacyAdaptee legacyAdaptee)
        {
            _legacyAdaptee = legacyAdaptee;
        }

        public string[] Request()
        {
            return _legacyAdaptee.SpecificRequest().Split(new char[] {','});
        }
    }
}
