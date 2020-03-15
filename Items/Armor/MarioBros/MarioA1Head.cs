using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MarioLand.Items.Armor.MarioBros
{
    [AutoloadEquip(EquipType.Head)]
    public class MarioA1Head : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Mario's Cap +1");
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
            player.setBonus = "Melee damage, Melee speed\n" +
                "and Defense up\n" +
                "Powered up!";

            player.AddBuff(mod.BuffType("MarioBuff"), 1);

            player.meleeDamage += 0.1f;
            player.meleeSpeed  += 0.1f;
            player.statDefense += 4;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("MarioAHead"));
            recipe.AddIngredient(ItemID.DemoniteBar, 1);
            recipe.AddIngredient(ItemID.ShadowScale, 1);
            recipe.AddIngredient(ItemID.Bone, 5);
            recipe.AddIngredient(ItemID.FallenStar, 3);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("MarioAHead"));
            recipe.AddIngredient(ItemID.CrimtaneBar, 1);
            recipe.AddIngredient(ItemID.TissueSample, 1);
            recipe.AddIngredient(ItemID.Bone, 5);
            recipe.AddIngredient(ItemID.FallenStar, 3);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}