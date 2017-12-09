using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Placeables
{
	public class EndlessDemonTorch : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Never-Ending Demon Torch");
        }

        public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
            item.autoReuse = true;
            item.useTurn = true;
            item.noWet = true;
            item.useStyle = 1;
            item.useAnimation = 15;
            item.useTime = 15;
            item.createTile = TileID.Torches;
            item.placeStyle = 7;
            item.shootSpeed = 6;
            item.noMelee = true;
            item.holdStyle = 1;
            item.flame = true;
			item.value = 1000;
			item.rare = 2;			
		}

        public override void HoldItem(Player player)
        {
            if (Main.rand.Next(player.itemAnimation > 0 ? 40 : 80) == 0)
            {             
                int index = Dust.NewDust(new Vector2(player.itemLocation.X + 16f * player.direction, player.itemLocation.Y - 20f * player.gravDir), 4, 4, 65, 0.0f, 0.0f, 100, new Color(), 1f);
                if (Main.rand.Next(3) != 0)
                    Main.dust[index].noGravity = true;
                Main.dust[index].velocity *= 0.3f;
                Main.dust[index].velocity.Y -= 1.5f;
                Main.dust[index].position = player.RotatedRelativePoint(Main.dust[index].position, true);
            }

            Vector2 position = player.RotatedRelativePoint(new Vector2(player.itemLocation.X + 12f * player.direction + player.velocity.X, player.itemLocation.Y - 14f + player.velocity.Y), true);

            if (!player.wet)
                Lighting.AddLight(position, (float)(0.5 * (double)Main.demonTorch + 1.0 * (1.0 - (double)Main.demonTorch)), 0.3f, (float)(1.0 * (double)Main.demonTorch + 0.5 * (1.0 - (double)Main.demonTorch)));
        }

        public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
        {
            dryTorch = true; 
        }

        public override void PostUpdate()
        {
            if (!item.wet)
            {
                Lighting.AddLight((int)((item.position.X + item.width / 2) / 16f), (int)((item.position.Y + item.height / 2) / 16f), (float)(0.5 * (double)Main.demonTorch + 1.0 * (1.0 - (double)Main.demonTorch)), 0.3f, (float)(1.0 * (double)Main.demonTorch + 0.5 * (1.0 - (double)Main.demonTorch)));
            }
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemonTorch, 999);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}