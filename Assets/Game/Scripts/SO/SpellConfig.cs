using Game.Utils;
using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.SO
{
    [InlineEditor]
    public class SpellConfig : ScriptableObject
    {
        public string spellID;
        public string spellName;
        [PropertyRange(0, 9)]
        public int spellLevel = 0;
        [Searchable]
        public SpellSchools school;
        [TextArea, MultiLineProperty(10), HideLabel, Title("description", bold: false)]
        public string description;
    }
}
