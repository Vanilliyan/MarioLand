using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MarioLand.Buffs.Characters.Wario
{
    public class WarioBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Wario Time!");
            Description.SetDefault(
                "\n Allows the player to dash into the enemy" +
                "\n Double tap a direction" +
                "\n" +
                "\n Damaging jump attack," +
                "\n swimming\n"
            );

            Main.buffNoTimeDisplay[Type] = true;
            canBeCleared = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            MarioPlayer mp = player.GetModPlayer<MarioPlayer>();
            mp.Wario = true;

            player.accFlipper = true;
            player.noFallDmg = true;

            if (!player.wet)
            {
                if (player.velocity.Y == 0)
                {
                    player.dash = 2;
                }
                player.jumpSpeedBoost += 1f;
                player.maxFallSpeed += 3f;
            }
        }
    }
}
