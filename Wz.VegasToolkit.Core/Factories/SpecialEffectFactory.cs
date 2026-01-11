using ScriptPortal.Vegas;
using System;
using System.Collections.Generic;

namespace Wz.VegasToolkit.Core.Factories
{
    public enum SpecialEffectType
    {
        TitlesAndText
    }

    public class SpecialEffectFactory : IEffectFactory<SpecialEffectType>
    {
        private readonly VegasContext _context;


        public SpecialEffectFactory(VegasContext context)
        {
            _context = context;
        }

        public PlugInNode Get(SpecialEffectType type)
        {
            var effect = _context.Vegas.Generators.GetChildByUniqueID(ScriptBase.EffectUniqueIdMap[type]);

            if (effect == null)
            {
                throw new InvalidOperationException($"Effect '{ScriptBase.EffectUniqueIdMap[type]}' not found in Vegas Pro.");
            }

            return effect;
        }
    }
}
