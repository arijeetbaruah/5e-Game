using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities.Editor;
using UnityEditor;
using UnityEngine;

namespace Game.Component.Editor
{
    public class BaseStatsDrawer : OdinValueDrawer<BaseStats>
    {
        protected override void DrawPropertyLayout(GUIContent label)
        {
            BaseStats stats = this.ValueEntry.SmartValue;

            //base.DrawPropertyLayout(label);
            Rect rect = EditorGUILayout.GetControlRect();
            EditorGUI.LabelField(rect, label);

            SirenixEditorGUI.BeginBox();

            stats.strenght = SirenixEditorFields.IntField(new GUIContent("Strenght"), stats.strenght);
            stats.dexterity = SirenixEditorFields.IntField(new GUIContent("Dexterity"), stats.dexterity);
            stats.constitution = SirenixEditorFields.IntField(new GUIContent("Constitution"), stats.constitution);
            stats.intelligent = SirenixEditorFields.IntField(new GUIContent("Intelligent"), stats.intelligent);
            stats.wisdom = SirenixEditorFields.IntField(new GUIContent("Wisdom"), stats.wisdom);
            stats.charisma = SirenixEditorFields.IntField(new GUIContent("Charisma"), stats.charisma);

            SirenixEditorGUI.EndBox();

            this.ValueEntry.SmartValue = stats;
        }
    }
}
