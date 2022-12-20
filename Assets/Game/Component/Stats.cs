using Unity.Entities;

namespace Game.Component
{
    public struct Stats : IComponentData
    {
        public BaseStats baseStats;
        public BaseStats savingThrow;
        public int proficiency;
    }
}
