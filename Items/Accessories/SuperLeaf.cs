using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace MarioLand.Items.Accessories
{
	[AutoloadEquip(EquipType.Wings)]
	public class SuperLeaf : ModItem
	{
        public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A leaf that makes you fly? That's super, alright! \nCan't be worn with other Power-Ups \nOnly works for Mario and Luigi");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 0;
			item.rare = 2;
			item.accessory = true;
		}

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            MarioPlayer mp = player.GetModPlayer<MarioPlayer>();
            mp.Leaf = true;

            if (player.velocity.X >= 3f || player.velocity.X <= -3f)
            {
                player.wingTimeMax = 30;
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
			ascentWhenFalling = 0.5f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 0.5f;
			maxAscentMultiplier = 1f;
            constantAscend = 1f;         
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
			recipe.AddIngredient(ItemID.FallenStar, 3);
            recipe.AddTile(TileID.Trees);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}