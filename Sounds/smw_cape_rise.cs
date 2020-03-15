using Microsoft.Xna.Framework.Audio;
using Terraria;
using Terraria.ModLoader;

namespace MarioLand.Sounds
{
	public class smw_cape_rise : ModSound
	{
		public override SoundEffectInstance PlaySound(ref SoundEffectInstance soundInstance, float volume, float pan, SoundType type)
		{
			if (soundInstance.State == SoundState.Playing)
				return null;
			return soundInstance;
		}
	}
}
