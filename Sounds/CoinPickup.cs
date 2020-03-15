using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MarioLand.Sounds
{
    public class CoinPickup : GlobalItem
    {
        public override bool OnPickup(Item item, Player player)
        {
            MarioPlayer mp = player.GetModPlayer<MarioPlayer>();
            if (mp !=null && new int[] { ItemID.CopperCoin, ItemID.SilverCoin, ItemID.GoldCoin, ItemID.PlatinumCoin }.Contains(item.type))
            {
                if ((mp.MarioChar) == true)
                {
                    Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/smw_coin"));
                }
                if ((mp.Wario) == true)
                {
                    Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/Wario/wario_coin"));
                }

            }
            return base.OnPickup(item, player);
        }
    }
}
