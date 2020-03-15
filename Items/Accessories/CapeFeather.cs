using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace MarioLand.Items.Accessories
{
	[AutoloadEquip(EquipType.Wings)]
	public class CapeFeather : ModItem
	{
        public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("No surprise that a feather is involved in flight.\nCan't be worn with other Power-Ups \nOnly works for Mario and Luigi");
		}

		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 16;
			item.value = 0;
			item.rare = 2;
			item.accessory = true;
		}

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            MarioPlayer mp = player.GetModPlayer<MarioPlayer>();
            mp.Cape = true;

            for (int i = 0; i < 100; i++)
            {
                if (player.velocity.X >= 3f || player.velocity.X <= -3f)
                {
                    player.wingTimeMax = 100;
                }
                if (player.velocity.Y > 5.5f && (player.velocity.X > 4f || player.velocity.X < -4f))
                {
                    player.wingTime = (0.125f * i);
                }
            } 
        }

        public override bool WingUpdate(Player player, bool inUse)
        {
            MarioPlayer mp = player.GetModPlayer<MarioPlayer>();
            if (inUse)
            {
                player.flapSound = true;
            }

            if ((player.wingFrame == 3 && mp.MarioChar == true) && player.wet == false && player.wingTime < 10 && (player.velocity.X > 4f || player.velocity.X < -4f))
            {
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/smw_cape_rise"));
            }
            return false;
        }

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 3f;
            ascentWhenRising = 3f;
            maxCanAscendMultiplier = 1f;
            maxAscentMultiplier = 1f;
            constantAscend = 1f;
        }

        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            MarioPlayer mp = player.GetModPlayer<MarioPlayer>();
            if (mp.MarioChar == true)
            {
                speed = 8f;
                acceleration *= 3f;
            }
            if (mp.MarioChar == false || player.controlUseItem)
            {
                player.wingsLogic = 0;
            }
        }

        public override bool CanEquipAccessory(Player player, int slot)
        {
            List<int> others = new List<int> { mod.ItemType("FireFlower"), mod.ItemType("IceFlower"), mod.ItemType("SuperLeaf"), mod.ItemType("FrogSuit"), mod.ItemType("TanookiSuit"),
                                               mod.ItemType("HammerSuit"), mod.ItemType("CapeFeather"), mod.ItemType("BuilderHat") };
            for (int j = 0; j < player.armor.Length; j++)
            {
                if (others.Contains(player.armor[j].type))
                {
                    return false;
                }
            }
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GiantHarpyFeather, 1);
            recipe.AddIngredient(ItemID.SoulofFlight, 20);
            recipe.AddIngredient(ItemID.FallenStar, 3);
            recipe.AddTile(TileID.Trees);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}