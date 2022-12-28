using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;

namespace Game.Utils
{
    [System.Serializable]
    public struct DiceDetail
    {
        public int count;
        public int face;

        public int RollDice(Random random)
        {
            int sum = 0;

            for (int index = 0; index < count; index++)
            {
                sum += random.NextInt(face);
            }

            return sum;
        }
    }
}
