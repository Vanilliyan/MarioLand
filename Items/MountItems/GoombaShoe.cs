using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MarioLand.Items.MountItems
{
	public class GoombaShoe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Goomba's Shoe");
			Tooltip.SetDefault("Hop in and hop around");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 4));
			ItemID.Sets.ItemIconPulse[item.type] = false;
			ItemID.Sets.ItemNoGravity[item.type] = false;
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			
			item.useTime = 20;
			item.useStyle = 4;
			item.useAnimation = 1;
			
			item.rare = 1;
			item.value = Item.sellPrice(0, 0, 10, 0);
			
			item.mountType = mod.MountType("GoombaShoe");
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/hit1");
			
			item.noMelee = true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GreenDye, 1);
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddIngredient(ItemID.Chain, 3);
         // recipe.AddIngredient(null, "MarioAHead", 10);
            recipe.AddTile(TileID.Loom);					
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}