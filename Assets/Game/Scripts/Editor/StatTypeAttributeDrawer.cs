using Game.Component;
using Sirenix.OdinInspector.Editor;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Game.Utils.Editor
{
    public class StatTypeAttributeDrawer : OdinAttributeDrawer<StatTypeAttribute, string>
    {
        protected override void DrawPropertyLayout(GUIContent label)
        {
            string val = this.ValueEntry.SmartValue;

            List<string> skillList = CharacterSkillsConfig.Instance.SkillList;
            int index = skillList.IndexOf(val);
            index = index == -1 ? 0 : index;
            index = EditorGUILayout.Popup(label, index, skillList.ToArray());
            val = skillList[index];

            this.ValueEntry.SmartValue = val;
        }
    }
}
