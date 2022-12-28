using Game.SO;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using UnityEditor;
using UnityEngine;

namespace Game.Utils
{
    public class CreateAbilityWindow : OdinEditorWindow
    {
        [InlineEditor]
        public AbilityConfig ability = null;

        [MenuItem("RPG/Create Ability")]
        public static void OpenWindow()
        {
            CreateAbilityWindow window = GetWindow<CreateAbilityWindow>();
            window.Show();
            window.ability = ScriptableObject.CreateInstance<AbilityConfig>();
        }

        [Button]
        public void Save()
        {
            AbilityRegistry.Instance.abilityRegistry.Add(ability.abilityID, ability);
            EditorUtility.SetDirty(AbilityRegistry.Instance);
            AssetDatabase.CreateAsset(ability, $"Assets/Game/Resources/Ability/{ability.abilityID}.asset");
            AssetDatabase.SaveAssets();
        }
    }
}
