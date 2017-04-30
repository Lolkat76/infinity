using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Throwables
{
	public class EndlessGlowstick : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Endless Glowstick";
			item.width = 12;
			item.height = 12;
            item.useStyle = 1;
            item.alpha = 75;
            item.color = new Color(255f, 255f, 255f, 0f);
            item.useAnimation = 15;
            item.useTime = 15;
            item.UseSound = SoundID.Item1;
            item.shoot = ProjectileID.Glowstick;
            item.shootSpeed = 6;
            item.noMelee = true;
            item.holdStyle = 1;
            item.toolTip = "Infinite Glowsticks";
			item.value = 1000;
			item.rare = 2;
			
		}

        public override void HoldItem(Player player)
        {
            Vector2 position = player.RotatedRelativePoint(new Vector2(player.itemLocation.X + 12f * player.direction + player.velocity.X, player.itemLocation.Y - 14f + player.velocity.Y), true);
            Lighting.AddLight(position, 0.7f, 1f, 0.8f);
        }

        public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
        {
            glowstick = true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Glowstick, 396);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}