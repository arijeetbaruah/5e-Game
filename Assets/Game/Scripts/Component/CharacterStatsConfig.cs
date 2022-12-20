using System.Collections.Generic;
using System.Linq;
using Game.Utils;
using Sirenix.OdinInspector;
using Sirenix.Utilities;
using UnityEngine;

namespace Game.Component
{
    [GlobalConfig("Assets/Resources/Config/")]
    public class CharacterSkillsConfig : GlobalConfig<CharacterSkillsConfig>
    {
        [ShowInInspector, SerializeField]
        public StatTypeScriptableObjectDictionary skillRegistory = new StatTypeScriptableObjectDictionary();

        public List<string> SkillList => skillRegistory.Keys.ToList();
    }
}
