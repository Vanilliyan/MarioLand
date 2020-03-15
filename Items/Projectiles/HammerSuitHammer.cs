using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MarioLand.Items.Projectiles
{
    public class HammerSuitHammer : ModProjectile
    {
        public override void SetDefaults()
        {

            projectile.width     =  22;
            projectile.height    = 22;
            projectile.friendly  = true;
            projectile.aiStyle   = 2;
            projectile.timeLeft  = 4000;
            projectile.penetrate = -1;
            //projectile.light = 0.0f;
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
            ProjectileID.Sets.TrailingMode[projectile.type] = 2;
            projectile.tileCollide = false;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hammer Suit Hammer");

        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            projectile.ai[0] += 0.1f;
            projectile.velocity *= 0.75f;
        }
    }
}