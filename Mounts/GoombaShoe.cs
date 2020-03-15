using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MarioLand.Mounts // change to mod name
{
    public class GoombaShoe : ModMountData // change to file name
    {
        public override void SetDefaults()
        {
            mountData.spawnDust = mod.DustType("SmokeTransformDust");
            mountData.buff = mod.BuffType("GoombaShoeBuff");
            mountData.heightBoost = 1;          //how high is the mount from the ground
            mountData.fallDamage = 0f;
            mountData.runSpeed = 4f;
            mountData.dashSpeed = 4f;
            mountData.fatigueMax = 0;
            mountData.jumpHeight = 8;
            mountData.acceleration = 0.3f;
            mountData.jumpSpeed = 10f;
            mountData.blockExtraJumps = false;
            mountData.totalFrames = 8;            //mount frame/animation

            //mountData.swimSpeed = 15f;

            int[] array = new int[mountData.totalFrames]; //Where does the player's body go to, higher number means higher.
            for (int l = 0; l < array.Length; l++)
            {
                array[0] = 5;
                array[1] = 4;
                array[2] = 4;
                array[3] = 4;
                array[4] = 4;
                array[5] = 7;
                array[6] = 10;
                array[7] = 7;
            }
            mountData.playerYOffsets = array; // Makes the character bop up and down while moving
            
            mountData.xOffset = 2;
            mountData.yOffset = 0;          //how high is the mount from the player
            mountData.bodyFrame = 3;          //player frame when it's on the mount
            mountData.playerHeadOffset = 0;
            mountData.standingFrameCount = 4;
            mountData.standingFrameDelay = 10;
            mountData.standingFrameStart = 0;
            mountData.runningFrameCount = 4;
            mountData.runningFrameDelay = 20;
            mountData.runningFrameStart = 4;
            mountData.dashingFrameCount = 4;
            mountData.dashingFrameDelay = 20;
            mountData.dashingFrameStart = 4;
            mountData.flyingFrameCount = 4;
            mountData.flyingFrameDelay = 20;
            mountData.flyingFrameStart = 0;
            mountData.inAirFrameCount = 4;
            mountData.inAirFrameDelay = 20;
            mountData.inAirFrameStart = 0;
            mountData.idleFrameCount = 4;
            mountData.idleFrameDelay = 20;
            mountData.idleFrameStart = 0;
            mountData.idleFrameLoop = false;
            mountData.swimFrameCount = 4;
            mountData.swimFrameDelay = 20;
            mountData.swimFrameStart = 0;
            if (Main.netMode != 2)
            {
                mountData.textureWidth = mountData.frontTexture.Width;
                mountData.textureHeight = mountData.frontTexture.Height;
            }
        }
        /*
    public virtual bool UpdateFrame(Player mountedPlayer, int state, Vector2 velocity)
    {
        return true;
    }
    */

        //public override void UpdateEffects(Player player)
        //{
        //    if (Math.Abs(player.velocity.X) > 4f)
        //    {
        //        Rectangle rect = player.getRect();
        //        Dust.NewDust(new Vector2(rect.X, rect.Y), rect.Width, rect.Height, DustID.Confetti);
        //    }
        //}
    }
}