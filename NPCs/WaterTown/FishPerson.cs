using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static prismmod.PrismHelper;

namespace prismmod.NPCs.WaterTown
{
    internal class FishPerson : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fish Person");
            Main.npcFrameCount[npc.type] = 16;//107 if NPCID is incorrect
        }

        public override void SetDefaults()
        {
            npc.townNPC = true;
            npc.width = 32;
            npc.height = 52;
            animationType = NPCID.GoblinTinkerer;
            npc.aiStyle = 7;
            npc.lifeMax = 75;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 0.75f;
            npc.knockBackResist = 0.5f;
            npc.damage = 14;
            npc.friendly=true;
        }

        public override void AI()
        {
            npc.breath = 100;
            npc.breathCounter = 100;
        }

        public override string TownNPCName()
        {
            int nameNum = Main.rand.Next(fishNames.Length);
            return fishNames[nameNum];//uses fishNames from PrismHelper

        }
    }
}