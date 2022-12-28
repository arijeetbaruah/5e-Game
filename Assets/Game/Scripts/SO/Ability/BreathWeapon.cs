using Game.Utils;
using Unity.Mathematics;

namespace Game.SO.Ability
{
    [UnityEngine.CreateAssetMenu(menuName = "Abilities/Breath Weapon")]
    public class BreathWeapon : AbilityConfig, IAbility
    {
        public DiceDetail damageDie;

        public int Damage(Random random)
        {
            return damageDie.RollDice(random);
        }
    }
}
