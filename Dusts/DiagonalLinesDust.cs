using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace MarioLand.Dusts
{
    class DiagonalLinesDust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.scale *= 2f;
        }

        public override bool Update(Dust dust)
        {
            dust.position += dust.velocity;
            dust.scale -= 0.1f;
            if (dust.scale < 0.005f)
            {
                dust.active = false;
            }
            return false;
        }
    }
}