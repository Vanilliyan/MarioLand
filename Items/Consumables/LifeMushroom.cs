/*using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MarioLand.Items.Consumables
{
    public class LifeMushroom : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Powers up Mario characters! \nCan only be eaten after the wall down below has been defeated");
        }

        public override void SetDefaults()
        {
            item.useStyle = 4;
            item.useAnimation = 30;
            item.useTime = 30;
            item.width = 16;
            item.height = 16;
            item.value = 40000;
            item.rare = 8;
            item.consumable = true;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/lifemushroom");

        }

        public override bool UseItem(Player player)
        {
            MarioPlayer mp = player.GetModPlayer<MarioPlayer>();
            mp.PoweredUp = true;
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (Main.hardMode)
            {
                MarioPlayer mp = player.GetModPlayer<MarioPlayer>();
                if (mp.PoweredUp == false)
                {
                    return true;
                }
            }
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Mushroom, 10);
            recipe.AddIngredient(ItemID.FallenStar, 5);
            recipe.AddIngredient(ItemID.LifeCrystal, 1);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}*/