using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MarioLand.Items.Armor.Wario
{
    [AutoloadEquip(EquipType.Head)]
    public class WarioAHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Wario's Cap");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 0;
            item.rare = 8;
            item.defense = 3;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("WarioBody") && legs.type == mod.ItemType("WarioLegs");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "HP, Melee damage \nand Defense up";

            player.AddBuff(mod.BuffType("WarioBuff"), 1);

            player.statLifeMax2 += 10;
            player.meleeDamage  += 0.1f;
            player.statDefense  += 5;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 2);
            recipe.AddIngredient(ItemID.YellowDye, 1);
            recipe.AddIngredient(ItemID.Mushroom, 3);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}