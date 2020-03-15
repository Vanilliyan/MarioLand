using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MarioLand.Buffs
{
    public class GoombaShoeBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Goomba's Shoe");
            Description.SetDefault("Takes booting to a new level");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(mod.MountType("GoombaShoe"), player);
            player.buffTime[buffIndex] = 4000;
            player.noFallDmg = true;
            //player.accFlipper = true;
            //player.doubleJumpSail = true;
			
			//player.accDivingHelm = true;
			//player.waterWalk = true;
			//player.ignoreWater = true;
        }
    }
}
