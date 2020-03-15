using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace MarioLand.Items.Accessories
{
	[AutoloadEquip(EquipType.Wings)]
	public class TanookiSuit : ModItem
	{
        public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A comfy suit that enhanced the Super Leaf's power.\nCan't be worn with other Power-Ups \nOnly works for Mario and Luigi");
		}

		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 16;
			item.value = 0;
			item.rare = 2;
			item.accessory = true;
		}

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            MarioPlayer mp = player.GetModPlayer<MarioPlayer>();
            mp.Tanooki = true;

            if (player.velocity.X >= 3f || player.velocity.X <= -3f)
            {
                player.wingTimeMax = 150;
            }
        }

        public override bool WingUpdate(Player player, bool inUse)
        {
            MarioPlayer mp = player.GetModPlayer<MarioPlayer>();
            if (inUse)
            {
                player.flapSound = true;
            }

            if ((player.wingFrame == 3 && (mp.Mario || mp.Luigi == true)) && player.wet == false)
            {
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/tail_cape_spin"));
            }
            return false;
        }

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
			ascentWhenFalling = 0.6f;
			ascentWhenRising = 0.25f;
			maxCanAscendMultiplier = 0.6f;
			maxAscentMultiplier = 1.1f;
            constantAscend = 1.1f;         
        }

        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            MarioPlayer mp = player.GetModPlayer<MarioPlayer>();
            if (mp.Mario || mp.Luigi == true)
            {
                speed = 5f;
                acceleration *= 1.5f;
            }
            if (!mp.Mario && !mp.Luigi == true)
            {
                player.wingsLogic = 0;
            }
        }

        public override bool CanEquipAccessory(Player player, int slot)
        {
            List<int> others = new List<int> { mod.ItemType("FireFlower"), mod.ItemType("IceFlower"), mod.ItemType("SuperLeaf"), mod.ItemType("FrogSuit"), mod.ItemType("TanookiSuit"),
                                               mod.ItemType("HammerSuit"), mod.ItemType("CapeFeather"), mod.ItemType("BuilderHat") };
            for (int j = 0; j < player.armor.Length; j++)
            {
                if (others.Contains(player.armor[j].type))
                {
                    return false;
                }
            }
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("SuperLeaf"));
            recipe.AddIngredient(ItemID.SoulofFlight, 20);
            recipe.AddIngredient(ItemID.FallenStar, 3);
            recipe.AddTile(TileID.Trees);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}