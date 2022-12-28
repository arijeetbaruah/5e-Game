using Game.Utils;
using Sirenix.OdinInspector.Editor;
using UnityEngine;
using UnityEditor;
using Sirenix.Utilities.Editor;

namespace Game.Editor
{
    public class DiceDetailDrawer : OdinValueDrawer<DiceDetail>
    {
        protected override void DrawPropertyLayout(GUIContent label)
        {
            DiceDetail diceDetail = this.ValueEntry.SmartValue;

            EditorGUILayout.LabelField(label);
            EditorGUILayout.BeginHorizontal();

            diceDetail.count = SirenixEditorFields.IntField(diceDetail.count);
            diceDetail.face = SirenixEditorFields.IntField(diceDetail.face);

            EditorGUILayout.EndHorizontal();

            this.ValueEntry.SmartValue = diceDetail;
        }
    }
}
