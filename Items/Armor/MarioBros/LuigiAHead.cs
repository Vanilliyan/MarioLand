using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MarioLand.Items.Armor.MarioBros
{
    [AutoloadEquip(EquipType.Head)]
    public class LuigiAHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Luigi's Cap");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 0;
            item.rare = 2;
            item.defense = 3;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("LuigiBody") && legs.type == mod.ItemType("BrosLegs");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "HP and Defense up";

            player.AddBuff(mod.BuffType("LuigiBuff"), 1);

            player.statLifeMax2 += 10;
            player.statDefense += 3;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 2);
            recipe.AddIngredient(ItemID.GreenDye, 1);
            recipe.AddIngredient(ItemID.Mushroom, 3);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}