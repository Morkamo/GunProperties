using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Enums;
using PlayerRoles;

namespace GunProperties
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        
        [Description("RoleDamage - базовый наносимый урон для роли (SCP)")]
        public Dictionary<RoleTypeId, float> RolesDamages { get; set; } = new Dictionary<RoleTypeId, float>()
        {
            [RoleTypeId.Scp049] = 100f,
        };
        
        [Description("ItemDamage - базовый наносимый урон для оружия")]
        public Dictionary<DamageType, float> ItemsDamages { get; set; } = new Dictionary<DamageType, float>()
        {
            [DamageType.A7] = 40f,
        };

        [Description("HitboxDamage - множитель урона при попадании в часть тела (1 - стандратный урон)")]
        public Dictionary<HitboxType, float> HitboxDamage { get; set; } = new Dictionary<HitboxType, float>()
        {
            [HitboxType.Headshot] = 2f,
            [HitboxType.Body] = 1f,
            [HitboxType.Limb] = 0.48f,
        };
    }
}