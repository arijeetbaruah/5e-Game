using Game.Component;
using UnityEngine;
using Sirenix.OdinInspector;
using Unity.Entities;
using Game.Utils;
using System.Collections.Generic;

namespace Game.Authing
{
    public class StatsAuthing : MonoBehaviour
    {
        [TabGroup("Base Stats")]
        public BaseStats baseStats;
        [TabGroup("SavingThrow")]
        public BaseStats savingThrow;
        public int proficiency;
    }

    public class StatsBaker : Baker<StatsAuthing>
    {
        public override void Bake(StatsAuthing authoring)
        {
            AddComponent(new Stats
            {
                baseStats = authoring.baseStats,
                savingThrow  = authoring.savingThrow,
                proficiency = authoring.proficiency
            });
        }
    }
}
