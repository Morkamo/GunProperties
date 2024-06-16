using System;
using Exiled.API.Features;

using evArgs = Exiled.Events.Handlers.Player;
using ItemArgs = Exiled.Events.Handlers.Item;

namespace GunProperties
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance;
        
        public override string Author => "Morkamo";
        public override string Name => "GunProperties";
        public override string Prefix => Name;
        public override Version Version => new Version(1, 0, 0);
        
        internal GunSettings _GunSettings;

        public override void OnEnabled()
        {
            Instance = this;
            
            _GunSettings = new GunSettings();
            
            evArgs.Shot.Subscribe(_GunSettings.OnShot);
            evArgs.Hurting.Subscribe(_GunSettings.OnHurting);

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Instance = null;
            
            evArgs.Shot.Unsubscribe(_GunSettings.OnShot);
            evArgs.Hurting.Unsubscribe(_GunSettings.OnHurting);
            
            _GunSettings = null;

            base.OnDisabled();
        }
    }
}