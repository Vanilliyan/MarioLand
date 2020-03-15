using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MarioLand.Items.Bags
{
	public class HammerSet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hammer Suit Set");
			Tooltip.SetDefault("Right-click to get the Hammer Suit!");
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
			player.QuickSpawnItem(mod.ItemType("HammerSuit"), Main.rand.Next(1, 1));
			player.QuickSpawnItem(mod.ItemType("HammerSuitHammer"), Main.rand.Next(1, 1));
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Bone,       20);
            recipe.AddIngredient(ItemID.BorealWood, 20);
            recipe.AddIngredient(ItemID.StoneBlock, 20);
            recipe.AddIngredient(ItemID.FallenStar,  1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}