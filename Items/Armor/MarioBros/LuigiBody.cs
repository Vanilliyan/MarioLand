using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MarioLand.Items.Armor.MarioBros
{
	[AutoloadEquip(EquipType.Body)]
	public class LuigiBody : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Luigi's Overalls");
		}

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 0;
            item.rare = 2;
            item.defense = 4;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemID.ScarecrowHat && legs.type == ItemID.FishCostumeFinskirt;
        }

        public override void UpdateArmorSet(Player player)
        {
            if (player.name == "VaniIIiyan")
            {
                player.setBonus = "How'd you get this?";

                MarioPlayer mp = player.GetModPlayer<MarioPlayer>();

                mp.MarioChar = true;
                mp.Luigi = true;

                mp.Dev = true;
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 5);
            recipe.AddIngredient(ItemID.GreenDye, 1);
            recipe.AddIngredient(ItemID.BlueDye, 1);
            recipe.AddIngredient(ItemID.GoldCoin, 2);
            recipe.AddIngredient(ItemID.Mushroom, 5);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool DrawBody()
        {
            return false;
        }
	}
}