using Game.Utils;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Game.SO
{
    [InlineEditor]
    public abstract class AbilityConfig : ScriptableObject
    {
        public string abilityID;
        public string abilityName;
        [TextArea, MultiLineProperty(10), HideLabel, Title("description", bold: false)]
        public string description;
    }

    public interface IAbility
    {
        int Damage(Unity.Mathematics.Random random);
    }

    [System.Serializable]
    public class AbilityDictionary : UnitySerializedDictionary<string, AbilityConfig>
    {
    }
}
