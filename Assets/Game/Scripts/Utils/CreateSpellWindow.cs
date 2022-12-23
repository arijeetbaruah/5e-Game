#if UNITY_EDITOR
using UnityEngine;
using Sirenix.OdinInspector.Editor;
using UnityEditor;
using Game.SO;
using Sirenix.OdinInspector;

namespace Game.Utils
{
    public class CreateSpellWindow : OdinEditorWindow
    {
        [InlineEditor]
        public SpellConfig spell = null;

        [MenuItem("RPG/Create Spell")]
        public static void OpenWindow()
        {
            CreateSpellWindow window = GetWindow<CreateSpellWindow>();
            window.Show();
            window.spell = ScriptableObject.CreateInstance<SpellConfig>();
        }

        [Button]
        public void Save()
        {
            SpellRegistery.Instance.spellRegistry.Add(spell.spellID, spell);
            EditorUtility.SetDirty(SpellRegistery.Instance);
            AssetDatabase.CreateAsset(spell, $"Assets/Game/Resources/Spells/{spell.spellID}.asset");
            AssetDatabase.SaveAssets();
        }
    }
}
#endif
