using Game.Component;
using UnityEngine;
using Sirenix.OdinInspector;
using Unity.Entities;

namespace Game.Authing
{
    /// <summary>
    /// Authing for Stats
    /// </summary>
    public class StatsAuthing : MonoBehaviour
    {
        [TabGroup("Base Stats")]
        public BaseStats baseStats;
        [TabGroup("SavingThrow")]
        public BaseStats savingThrow;
        public int proficiency;
    }

    /// <summary>
    /// Baker for StatsAuthing
    /// </summary>
    /// <inheritdoc cref="Bake(StatsAuthing)"/>
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
