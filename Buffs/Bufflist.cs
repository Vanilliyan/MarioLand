/*
using Terraria;
using Terraria.ModLoader;

namespace modname.Buffs
{
    public class buffname : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffName[this.Type] = "buff name";
            Main.buffTip[this.Type] = "buff tip";
            Main.buffNoSave[Type] = false;
            Main.debuff[Type] = false;
            canBeCleared = false;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.meleeDamage += 0.00f;
            player.meleeSpeed += 0.00f;
            player.meleeCrit += 0;

            player.rangedDamage += 0.00f;
            player.rangedCrit += 0;
            player.ammoCost80       = false;
            player.ammoCost75       = false;
            player.bulletDamage += 0.00f;
            player.arrowDamage += 0.00f;
            player.rocketDamage += 0.00f;

            player.magicDamage += 0.00f;
            player.magicCrit += 0;
            player.manaCost -= 1.00f;
            player.statManaMax2 += 0;                        
                                                
            player.thrownDamage += 0.00f;
            player.thrownVelocity += 0.00f;
            player.thrownCrit += 0;
            player.thrownCost50     = false;
            player.thrownCost33     = false;

            player.minionDamage += 0.00f;
            player.minionKB += 0.00f;
            player.maxMinions += 0;



            player.moveSpeed += 0.00f;
            player.pickSpeed += 0.00f;
            player.wallSpeed += 0.00f;
            player.tileSpeed += 0.00f;
            player.maxFallSpeed += 0.00f;
            player.maxRunSpeed += 0.00f;
            player.runSlowdown += 0.00f;

            player.accRunSpeed += 0;
            player.lifeRegen += 0;






            player.fishingSkill += 0;
            player.aggro += 0;

            player.statDefense += 0;
            player.extraFall += 0;
            player.spikedBoots += 0;
            player.dash += 0;
            player.endurance += 0.00f;
            player.lavaMax += 0;
            player.blockRange += 0;



            player.sporeSac         = false;
            player.shinyStone       = false;
            player.yoyoGlove        = false;
            player.yoyoString       = false;
            player.doubleJumpSandstorm = false;
            player.doubleJumpBlizzard  = false;
            player.doubleJumpFart   = false;
            player.doubleJumpCloud  = false;
            player.jumpBoost        = false;
            player.noFallDmg        = true;
            player.bee              = false;
            player.doubleJumpSail   = false;
            player.panic            = false;
            player.scope            = false;
            player.manaMagnet       = false;
            player.magicCuffs       = false;
            player.starCloak        = false;

            player.discount         = false;
            player.coins            = false;
            player.goldRing         = false;

            player.cordage          = false;

            player.coldDash         = false;
            player.sailDash         = false;

            player.noKnockback      = false;
            player.carpet           = false;
            player.blackBelt        = false;
            player.gravControl2     = false;
            player.brainOfConfusion = false;
            player.iceSkate         = false;
            player.accFlipper       = false;
            player.killGuide        = false;
            player.killClothier     = false;
            player.fireWalk         = false;
            player.accMerman        = false;
            player.hideMerman       = false;
            player.wolfAcc          = false;
            player.hideWolf         = false;
            player.longInvince      = false;
            player.pStone           = false;
            player.waterWalk2       = false;
            player.rulerLine        = false;
            player.rulerGrid        = false;
            player.accDivingHelm    = false;
            player.arcticDivingGear = false;
            player.kbGlove          = false;
            player.magmaStone       = false;
            player.magicQuiver      = false;
            player.lavaRose         = false;
            player.strongBees       = false;
            player.ignoreWater      = false;
            player.manaFlower       = false;
            player.forceWerewolf    = false;
            player.forceMerman      = false;
            player.shroomiteStealth = false;
            player.beetleOffense    = false;
            player.crimsonRegen     = false;
            player.ghostHeal        = false;
            player.ghostHurt        = false;
            player.spaceGun         = false;
            player.frostBurn        = false;
            player.turtleThorns     = false;
            player.onHitRegen       = false;
            player.onHitPetal       = false;
            player.onHitDodge       = false;
            player.slippy           = false;      - Slippery code
            player.slippy2          = false;      - Slippery code slime ice

            player.npcTypeNoAggro[1] = false; (Royal gel)
        }
    }
}
*/