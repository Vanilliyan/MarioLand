using Microsoft.Xna.Framework.Audio;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace MarioLand.Items.Accessories
{
	public class FrogSuit : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A nifty suit, made with the help of a frog\nCan't be worn with other Power-Ups \nOnly works for Mario and Luigi");
		}

		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 16;
			item.value = 1000;
			item.rare = 5;
			item.accessory = true;
		}

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            MarioPlayer mp = player.GetModPlayer<MarioPlayer>();
            mp.Frog = true;
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
			recipe.AddIngredient(ItemID.Flipper, 1);
            recipe.AddIngredient(ItemID.FrogLeg, 1);
            recipe.AddIngredient(ItemID.FallenStar, 1);
            recipe.AddTile(TileID.FrogCage);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}