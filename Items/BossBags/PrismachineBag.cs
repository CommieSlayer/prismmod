using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace prismmod.Items.BossBags
{
    public class PrismachineBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Prismatic Treasure Bag");
            Tooltip.SetDefault("Your Prismatic Loot Awaits You...");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.noMelee = true;
            item.consumable = true;
            item.useTime = 20;
            item.useStyle = 4;
            item.maxStack = 99;
            item.useAnimation = 15;
            item.expert = true;
        }

        public override void OpenBossBag(Player player)
        {
            bool wepGained = false;
            int choice = Main.rand.Next(4/*n-1*/);
            if (choice == 0)
            {
                player.QuickSpawnItem(mod.ItemType("RainBow"));
            }
            choice = Main.rand.Next(4/*n-1*/);
            if (choice == 1)
            {
                //wep 2
            }
            choice = Main.rand.Next(4/*n-1*/);
            if (choice == 1)
            {
                //wep 3
            }
            choice = Main.rand.Next(4/*n-1*/);
            if (choice == 1 || wepGained == false)
            {
                player.QuickSpawnItem(mod.ItemType("Prismaspear"));
            }
            //non weapon drops

            player.QuickSpawnItem(mod.ItemType("PrismachinePowerCore"));

            player.QuickSpawnItem(ItemID.GoldCoin, 10);
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override int BossBagNPC => mod.NPCType("Prismachine");
    }
}