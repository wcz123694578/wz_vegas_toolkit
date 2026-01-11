using System.Collections.Generic;
using Wz.VegasToolkit.Core.Factories;

namespace Wz.VegasToolkit.Core
{
    public class ScriptBase
    {
        public static readonly Dictionary<SpecialEffectType, string> EffectUniqueIdMap = new Dictionary<SpecialEffectType, string>()
        {
            { SpecialEffectType.TitlesAndText, "{Svfx:com.vegascreativesoftware:titlesandtext}" }
        };
    }
}
