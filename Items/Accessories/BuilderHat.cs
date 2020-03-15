using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace MarioLand.Items.Accessories
{
	public class BuilderHat : ModItem
	{
        public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Increases tile and wall placement speed and reach\n" +
                "Can't be worn with other Power-Ups \n" +
                "Only works for Mario and Luigi");
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
            mp.Builder = true;
        }

        public override bool CanEquipAccessory(Player player, int slot)
        {
            List<int> others = new List<int> { mod.ItemType("FireFlower"), mod.ItemType("IceFlower"), mod.ItemType("SuperLeaf"), mod.ItemType("FrogSuit"),
                                               mod.ItemType("TanookiSuit"), mod.ItemType("HammerSuit"), mod.ItemType("CapeFeather"), mod.ItemType("BuilderHat") };
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
            recipe.AddIngredient(ItemID.MiningHelmet, 1);
            recipe.AddIngredient(ItemID.FallenStar, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}