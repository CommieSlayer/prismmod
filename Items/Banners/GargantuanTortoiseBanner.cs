﻿using Terraria;
using Terraria.ModLoader;

namespace prismmod.Items.Banners
{
    public class GargantuanTortoiseBanner : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gargantuan Tortoise Banner");
            Tooltip.SetDefault("Nearby players get a bonus against: Gargantuan Tortoise");
        }

        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 24;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = Item.buyPrice(0, 0, 10, 0);
            item.createTile = mod.TileType("MonsterBanner");
            item.placeStyle = 1;
        }
    }
}