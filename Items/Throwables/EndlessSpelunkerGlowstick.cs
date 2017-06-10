using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Throwables
{
	public class EndlessSpelunkerGlowstick : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Spelunker Glowstick");
            Tooltip.SetDefault("Exposes nearby treasure");
        }

        public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
            item.useStyle = 1;
            item.alpha = 75;
            item.color = new Color(255f,255f,255f,0f);
            item.useAnimation = 15;
            item.useTime = 15;
            item.UseSound = SoundID.Item1;
            item.shoot = ProjectileID.SpelunkerGlowstick;
            item.shootSpeed = 6;
            item.noMelee = true;
            item.holdStyle = 1;
			item.value = 1000;
			item.rare = 2;			
		}

        public override void HoldItem(Player player)
        {
            Vector2 position = player.RotatedRelativePoint(new Vector2(player.itemLocation.X + 12f * player.direction + player.velocity.X, player.itemLocation.Y - 14f + player.velocity.Y), true);
            Lighting.AddLight(position, 1.05f, 0.95f, 0.55f);
            //Start of spelunker effect when holding the glowstick (Taken straight from my decompiled terraria sourcecode)
            player.spelunkerTimer++;
            if ((int)player.spelunkerTimer >= 10)
            {
                player.spelunkerTimer = (byte)0;
                int num1 = 30;
                int num2 = (int)player.Center.X / 16;
                int num3 = (int)player.Center.Y / 16;
                for (int index1 = num2 - 30; index1 <= num2 + num1; ++index1)
                {
                    for (int index2 = num3 - num1; index2 <= num3 + num1; ++index2)
                    {
                        if (Main.rand.Next(4) == 0 && ((double)new Vector2((float)(num2 - index1), (float)(num3 - index2)).Length() < (double)num1 && index1 > 0 && (index1 < Main.maxTilesX - 1 && index2 > 0) && (index2 < Main.maxTilesY - 1 && Main.tile[index1, index2] != null && Main.tile[index1, index2].active())))
                        {
                            bool flag2 = false;
                            if ((int)Main.tile[index1, index2].type == 185 && (int)Main.tile[index1, index2].frameY == 18)
                            {
                                if ((int)Main.tile[index1, index2].frameX >= 576 && (int)Main.tile[index1, index2].frameX <= 882)
                                    flag2 = true;
                            }
                            else if ((int)Main.tile[index1, index2].type == 186 && (int)Main.tile[index1, index2].frameX >= 864 && (int)Main.tile[index1, index2].frameX <= 1170)
                                flag2 = true;
                            if (flag2 || Main.tileSpelunker[(int)Main.tile[index1, index2].type] || Main.tileAlch[(int)Main.tile[index1, index2].type] && (int)Main.tile[index1, index2].type != 82)
                            {
                                int index3 = Dust.NewDust(new Vector2((float)(index1 * 16), (float)(index2 * 16)), 16, 16, 204, 0.0f, 0.0f, 150, new Color(), 0.3f);
                                Main.dust[index3].fadeIn = 0.75f;
                                Main.dust[index3].velocity *= 0.1f;
                                Main.dust[index3].noLight = true;
                            }
                        }
                    }
                }
            }
            //End of spelunker effect when holding the glowstick
        }

        public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
        {
            glowstick = true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpelunkerGlowstick, 396);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}