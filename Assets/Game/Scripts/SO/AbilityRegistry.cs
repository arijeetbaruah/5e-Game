using Game.Utils;
using Sirenix.OdinInspector;
using Sirenix.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.SO
{
    [GlobalConfig("Assets/Game/Resources/")]
    public class AbilityRegistry : GlobalConfig<AbilityRegistry>
    {
        [PropertyOrder(1)]
        public AbilityDictionary abilityRegistry;
    }
}
