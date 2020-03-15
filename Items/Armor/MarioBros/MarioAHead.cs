using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MarioLand.Items.Armor.MarioBros
{
    [AutoloadEquip(EquipType.Head)]
    public class MarioAHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Mario's Cap");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 0;
            item.rare = 10;
            item.defense = 3;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("MarioBody") && legs.type == mod.ItemType("BrosLegs");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Melee damage and Melee speed up";

            player.AddBuff(mod.BuffType("MarioBuff"), 1);

            player.meleeDamage += 0.05f;
            player.meleeSpeed  += 0.05f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 2);
            recipe.AddIngredient(ItemID.RedDye, 1);
            recipe.AddIngredient(ItemID.Mushroom, 3);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}