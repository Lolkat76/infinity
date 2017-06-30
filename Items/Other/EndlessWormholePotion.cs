using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Other
{
    public class EndlessWormholePotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Singularity Potion");
            Tooltip.SetDefault("Can teleport you throughout the galaxy..." +
                "\n...as long as your friends are there.");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.WormholePotion);
            item.maxStack = 1;
            item.consumable = false;
        }

        public override void UpdateInventory(Player player)
        {
            for (int index3 = 0; index3 < (int)byte.MaxValue; ++index3)
            {
                if (Main.player[index3].active && (!Main.player[Main.myPlayer].hostile && !Main.player[index3].hostile || Main.player[Main.myPlayer].team == Main.player[index3].team && Main.player[index3].team != 0 || index3 == Main.myPlayer))
                {
                    float scale = Main.mapFullscreenScale;
                    float num17 = 0.0f;
                    float num18 = 0.0f;
                    float num26b = Main.mapFullscreenPos.X;
                    float num27b = Main.mapFullscreenPos.Y;
                    float num28b = num26b * scale;
                    float num29b = num27b * scale;
                    float num30b = -num28b + (float)(Main.screenWidth / 2);
                    float num31b = -num29b + (float)(Main.screenHeight / 2);
                    float num15 = 200f;
                    float num16 = 300f;
                    float num11 = 10f;
                    float num12 = 10f;
                    num15 = num30b + num11 * scale;
                    num16 = num31b + num12 * scale;
                    float num21 = ((float)(((double)Main.player[index3].position.X + (double)(Main.player[index3].width / 2)) / 16.0) - num17) * scale;
                    float num22 = ((float)(((double)Main.player[index3].position.Y + (double)Main.player[index3].gfxOffY + (double)(Main.player[index3].height / 2)) / 16.0) - num18) * scale;
                    float num23 = num21 + num15;
                    float num24 = num22 + num16;
                    float num25 = num23 - 6f;
                    float num26 = num24 - 2f - (float)(2.0 - (double)scale / 5.0 * 2.0);
                    float X = num25 - 10f * scale;
                    float Y = num26 - 10f * scale;
                    float num28 = 1f;
                    float num27 = (float)((double)X + 4.0 - 14.0 * (double)num28);
                    float num29 = (float)((double)Y + 2.0 - 14.0 * (double)num28);
                    float num30 = num27 + 28f * num28;
                    float num31 = num29 + 28f * num28;

                    if (!Main.player[index3].dead)
                    {                       
                        if ((double)Main.mouseX >= (double)num27 && (double)Main.mouseX <= (double)num30 && ((double)Main.mouseY >= (double)num29 && (double)Main.mouseY <= (double)num31))
                        {
                            if (index3 != Main.myPlayer && Main.player[Main.myPlayer].team > 0 && (Main.player[Main.myPlayer].team == Main.player[index3].team && Main.netMode == 1))
                            {
                                if (Main.mouseLeft && Main.mouseLeftRelease)
                                {
                                    Main.mouseLeftRelease = false;
                                    Main.mapFullscreen = false;
                                    Main.player[Main.myPlayer].UnityTeleport(Main.player[index3].position);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
