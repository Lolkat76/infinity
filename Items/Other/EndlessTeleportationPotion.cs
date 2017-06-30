﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Other
{
    public class EndlessTeleportationPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Warp Potion");
            Tooltip.SetDefault("Can teleport you wherever you want..." +
                "\n...as long as you are lucky enough.");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.TeleportationPotion);
            item.maxStack = 1;
            item.consumable = false;
        }
        public override void HoldItem(Player player)
        {
            if (player.itemAnimation > 0)
            {
                if (player.itemTime == 0)
                    player.itemTime = item.useTime;
                else if (player.itemTime == 2)
                {
                    if (Main.netMode == 0)
                        player.TeleportationPotion();
                    else if (Main.netMode == 1 && player.whoAmI == Main.myPlayer)
                        NetMessage.SendData(73, -1, -1, null, 0, 0.0f, 0.0f, 0.0f, 0, 0, 0);

                }
            }
        }
    }
}
