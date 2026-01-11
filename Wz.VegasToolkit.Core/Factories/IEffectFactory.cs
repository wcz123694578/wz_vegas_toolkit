using ScriptPortal.Vegas;

namespace Wz.VegasToolkit.Core.Factories
{
    public interface IEffectFactory<TKey>
    {
        PlugInNode Get(TKey key);
    }
}
