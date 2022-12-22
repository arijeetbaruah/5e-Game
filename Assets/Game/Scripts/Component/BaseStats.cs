namespace Game.Component
{
    /// <summary>
    /// Holder of types of stats
    /// </summary>
    [System.Serializable]
    public struct BaseStats
    {
        public int strenght;
        public int dexterity;
        public int constitution;
        public int intelligent;
        public int wisdom;
        public int charisma;

        #region Setter and Getter
        public void SetStat(StatType stat, int value)
        {
            switch (stat)
            {
                case StatType.strenght:
                    strenght = value;
                    break;
                case StatType.dexterity:
                    dexterity = value;
                    break;
                case StatType.constitution:
                    constitution = value;
                    break;
                case StatType.intelligent:
                    intelligent = value;
                    break;
                case StatType.wisdom:
                    wisdom = value;
                    break;
                case StatType.charisma:
                    charisma = value;
                    break;
            }
        }

        public int GetStats(StatType stat)
        {
            switch(stat)
            {
                case StatType.strenght:
                    return strenght;
                case StatType.dexterity:
                    return dexterity;
                case StatType.constitution:
                    return constitution;
                case StatType.intelligent:
                    return intelligent;
                case StatType.wisdom:
                    return wisdom;
                case StatType.charisma:
                    return charisma;
                default:
                    return 0;
            }
        }
        #endregion
    }

    /// <summary>
    /// Stats Types
    /// </summary>
    public enum StatType
    {
        /// <remarks>How strong Physically</remarks>
        strenght,
        /// <remarks>How Agily and good with hands</remarks>
        dexterity,
        /// <remarks>How healthy is the individual</remarks>
        constitution,
        /// <remarks>Book smart</remarks>
        intelligent,
        /// <remarks>street smart</remarks>
        wisdom,
        /// <remarks>How good is he with words</remarks>
        charisma
    }
}
