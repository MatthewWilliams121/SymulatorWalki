using index.Properties;

namespace index
{
    public class Recon : Unit
    {
        public Recon(string name, int identityNumber, bool side, string strength) : base(name, identityNumber, side, strength)
        {
            unitImage = Resources.nato_mechanized;
            setSizeImageAndOrganization();
        }
    }
}