using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace MarioLand.Items.Accessories
{
	public class FireFlower : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Adds fire to your attacks!\nCan't be worn with other Power-Ups \nOnly works for Mario and Luigi");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 100;
			item.rare = 8;
			item.accessory = true;
		}

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            MarioPlayer mp = player.GetModPlayer<MarioPlayer>();
            mp.Fire = true;
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
			recipe.AddIngredient(ItemID.Daybloom, 5);
            recipe.AddIngredient(ItemID.FallenStar, 1);
            recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}