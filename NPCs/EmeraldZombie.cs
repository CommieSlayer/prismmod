﻿using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace prismmod.NPCs
{
    class EmeraldZombie : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Emerald Zombie");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
        }

        public override void SetDefaults()
        {
            npc.width =18;
            npc.height = 34;
            animationType = NPCID.Zombie;
            npc.aiStyle = 3;
            npc.lifeMax = 75;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 0.75f;
            npc.knockBackResist = 0.5f;

        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldNightMonster.Chance*0.1f;
        }

        public override void NPCLoot()
        {
            Item.NewItem(npc.getRect(), ItemID.Emerald, Main.rand.Next(3, 6));
        }


    }


}