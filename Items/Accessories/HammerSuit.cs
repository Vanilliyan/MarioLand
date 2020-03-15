using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace MarioLand.Items.Accessories
{
	public class HammerSuit : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Throwing damage and critical +5% \nDefense +3 \n \nCan't be worn with other Power-Ups \nOnly works for Mario and Luigi \n ");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 1000;
			item.rare = 3;
			item.accessory = true;
		}

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            MarioPlayer mp = player.GetModPlayer<MarioPlayer>();
            mp.Hammer = true;
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
	}
}