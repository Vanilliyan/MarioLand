using Microsoft.Xna.Framework.Audio;
using Terraria;
using Terraria.ModLoader;

namespace MarioLand.Sounds.Wario
{
	public class WarioSwim : ModSound
	{
		public override SoundEffectInstance PlaySound(ref SoundEffectInstance soundInstance, float volume, float pan, SoundType type)
		{
			if (soundInstance.State == SoundState.Playing)
				return null;
			return soundInstance;
		}
	}
}
