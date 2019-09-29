using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using System;
using Microsoft.Xna.Framework.Graphics;

namespace prismmod.NPCs.Prismachine
{
    class Orb : ModNPC
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Orb");
            Main.npcFrameCount[npc.type] = 1;
        }

        public override void SetDefaults()
        {
            //update hitbox to match sprite: KEEP HITBOX OUT OF ORB HITBOXES
            npc.width = 25;
            npc.height = 25;
            //no Ai Style
            npc.lifeMax = 100; //ask braden for life values
            //beware of generic hit sounds
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            //?npc.value = 0.75f;
            npc.knockBackResist = 1f;
            npc.damage = 1000; //lots of damage, should not get close to it, bceeause it should not get close to you
            // npc.immune = false;
            npc.noGravity = true;
            npc.noTileCollide = true;
        }
        
        
        public override void AI()
        {
            NPC prismachine = Main.npc[(int)npc.ai[0]];
        }

        public override void NPCLoot()
        {
            NPC prismachine = Main.npc[(int)npc.ai[0]];
            if (npc.ai[1] == 0)
            {
                prismachine.ai[0] += 1000;
                Main.NewText("Element 1 Attack Enabled!", 227, 76, 150);
            }
            else if (npc.ai[1] == 1)
            {
                prismachine.ai[0] += 100;
                Main.NewText("Element 2 Attack Enabled!", 0, 38, 227);
            }
            else if (npc.ai[1] == 2)
            {
                prismachine.ai[0] += 10;
                Main.NewText("Element 3 Attack Enabled!", 155, 2, 161);
            }
            else if (npc.ai[1] == 3)
            {
                prismachine.ai[0] += 1;
                Main.NewText("Element 4 Attack Enabled!", 112, 202, 204);
            }
            else {
                Main.NewText("Warning: Generic orb killed! No Element activated", 255,0,0);
            }
            
        }

    }
}
