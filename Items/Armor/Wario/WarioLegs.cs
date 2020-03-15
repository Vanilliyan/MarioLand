using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MarioLand.Items.Armor.Wario
{
	[AutoloadEquip(EquipType.Legs)]
	public class WarioLegs : ModItem
	{
		public override void SetStaticDefaults()
		{
            base.SetStaticDefaults();
            DisplayName.SetDefault("Wario's Boots");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 0;
			item.rare = 8;
			item.defense = 3;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(ItemID.Wood, 2);
            recipe.AddIngredient(ItemID.GreenDye, 2);
            recipe.AddIngredient(ItemID.Mushroom, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool DrawLegs()
        {
            return false;
        }
    }
}