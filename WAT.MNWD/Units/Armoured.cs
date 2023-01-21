using index.Properties;

namespace index
{
    public class Armoured : Unit
    {
        public Armoured(string name, int identityNumber, bool side, string strength) : base(name, identityNumber, side, strength)
        {
            unitImage = Resources.nato_armoured;
            setSizeImageAndOrganization();
        }
    }
}