using UnityEngine;
using Sirenix.OdinInspector;
using Sirenix.Utilities;
using Game.Utils;
using System.Collections.Generic;
using System.Linq;

namespace Game.SO
{
    [GlobalConfig("Assets/Game/Resources/")]
    public class SpellRegistery : GlobalConfig<SpellRegistery>
    {
        [Space]

        [PropertyOrder(1)]
        public SpellDictionary spellRegistry;

        [ButtonGroup]
        public void CreateSpell()
        {
#if UNITY_EDITOR
            CreateSpellWindow.OpenWindow();
#endif
        }

        [ButtonGroup]
        public void Refresh()
        {
            SpellConfig[] spells =Resources.LoadAll<SpellConfig>("Spells");
            foreach(SpellConfig spell in spells)
            {
                if (!spellRegistry.TryGetValue(spell.spellID, out SpellConfig currentSpell))
                {
                    spellRegistry.Add(spell.spellID, spell);
                }
            }
        }
    }

    [System.Serializable]
    public class SpellDictionary : UnitySerializedDictionary<string, SpellConfig>
    {
    }
}
