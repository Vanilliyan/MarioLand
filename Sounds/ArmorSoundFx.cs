using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace MarioLand.Sounds
{

	class ArmorSoundFX : ModPlayer
	{
        public override bool PreHurt(bool pvp, bool quiet, ref int damage, ref int hitDirection,
        ref bool crit, ref bool customDamage, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
        {
            MarioPlayer mp = player.GetModPlayer<MarioPlayer>();

            int currentSound = 0;
            int customSoundType = 0;

            if (mp.Mario == true)
            {
                playSound = false;

                if (mp.Invincible == false)
                {
                    currentSound = mod.GetSoundSlot(SoundType.Custom, "Sounds/mario_hurt");
                    customSoundType = SoundLoader.customSoundType;
                    Main.PlaySound(customSoundType, (int)player.Center.X, (int)player.Center.Y, currentSound, 1f, 0f);
                }
            }

            else if (mp.Luigi == true)
            {
                playSound = false;

                if (mp.Invincible == false)
                {
                    currentSound = mod.GetSoundSlot(SoundType.Custom, "Sounds/luigi_hurt");
                    customSoundType = SoundLoader.customSoundType;
                    Main.PlaySound(customSoundType, (int)player.Center.X, (int)player.Center.Y, currentSound, 1f, 0f);
                }
            }

            else if (mp.Wario == true)
            {
                playSound = false;

                currentSound = mod.GetSoundSlot(SoundType.Custom, "Sounds/Wario/wario_hurt");
                customSoundType = SoundLoader.customSoundType;
                Main.PlaySound(customSoundType, (int)player.Center.X, (int)player.Center.Y, currentSound, 1f, 0f);
            }


            return base.PreHurt(pvp, quiet, ref damage, ref hitDirection, ref crit, ref customDamage, ref playSound, ref genGore, ref damageSource);
        }
	}
}
