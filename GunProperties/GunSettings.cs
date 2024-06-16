using Exiled.API.Enums;
using Exiled.CustomItems.API.Features;
using Exiled.Events.EventArgs.Player;

namespace GunProperties
{
    internal class GunSettings
    {
        internal void OnHurting(HurtingEventArgs ev)
        {
            if (ev.Attacker is not null && Plugin.Instance.Config.RolesDamages.TryGetValue(ev.Attacker.Role.Type, out float roleDamage) && ev.DamageHandler.Type != DamageType.Jailbird)
            {
                ev.Amount = roleDamage;
            }

            if (ev.DamageHandler is not null && Plugin.Instance.Config.ItemsDamages.TryGetValue(ev.DamageHandler.Type, out float itemDamage) && ev.DamageHandler.Type != DamageType.Jailbird)
            {
                if (ev.Attacker is not null && CustomItem.TryGet(ev.Attacker.CurrentItem, out CustomItem _))
                    return;

                ev.Amount = itemDamage;
            }
        }

        internal void OnShot(ShotEventArgs ev)
        {
            if (Plugin.Instance.Config.HitboxDamage.TryGetValue(ev.Hitbox.HitboxType, out float damage))
            {
                if (ev.Hitbox.HitboxType == HitboxType.Headshot)
                {
                    ev.Damage = (ev.Damage / 2) * damage;
                    return;
                }
                
                if (ev.Hitbox.HitboxType == HitboxType.Limb)
                {
                    ev.Damage = (ev.Damage * 1.47f) * damage;
                    return;
                }

                ev.Damage = ev.Damage * damage;
            }
        }
    }
}