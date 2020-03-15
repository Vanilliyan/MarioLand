/*
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MarioLand.Items.Bags
{
	public class BuilderSet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Builder Suit Set");
			Tooltip.SetDefault("Right-click to get the Builder Suit!");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			
			item.maxStack = 1;
			
			item.rare = 12;
            item.value = 2000;
        }

		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			player.QuickSpawnItem(mod.ItemType("BuilderHat"), Main.rand.Next(1, 1));
			player.QuickSpawnItem(mod.ItemType("SuperMallet"), Main.rand.Next(1, 1));
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MiningHelmet, 20);
            recipe.AddIngredient(ItemID.BorealWood,   20);
            recipe.AddIngredient(ItemID.StoneBlock,   20);
            recipe.AddIngredient(ItemID.FallenStar,    7);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
*/