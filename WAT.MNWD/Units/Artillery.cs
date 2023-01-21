using index.Properties;

namespace index
{
    public class Artillery : Unit
    {
        public Artillery(string name, int identityNumber, bool side, string strength) : base(name, identityNumber, side, strength)
        {
            unitImage = Resources.nato_mechanized;
            setSizeImageAndOrganization();
        }
    }
}