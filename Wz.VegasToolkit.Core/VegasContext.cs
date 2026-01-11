using ScriptPortal.Vegas;

namespace Wz.VegasToolkit.Core
{
    public class VegasContext
    {
        public Vegas Vegas { get; }
        public VegasContext(Vegas vegas)
        {
            Vegas = vegas;
        }
    }
}
