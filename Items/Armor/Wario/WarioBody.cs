using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MarioLand.Items.Armor.Wario
{
	[AutoloadEquip(EquipType.Body)]
	public class WarioBody : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Wario's Overalls");
		}
        
        public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 0;
			item.rare = 8;
			item.defense = 4;
		}

        public override void UpdateEquip(Player player)
		{
			///player.buffImmune[BuffID.OnFire] = true;
			///player.statManaMax2 += 20;
			///player.maxMinions +=10;
            ///player.maxRunSpeed = 10;
            ///player.meleeCrit = 100;
            ///player.meleeDamage = 999;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 5);
            recipe.AddIngredient(ItemID.YellowDye, 1);
            recipe.AddIngredient(ItemID.VioletDye, 1);
            recipe.AddIngredient(ItemID.SilverCoin, 2);
            recipe.AddIngredient(ItemID.Mushroom, 5);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();

            //recipe = new ModRecipe(mod);
        }

            public override bool DrawBody()
        {
            return false;
        }
	}
}