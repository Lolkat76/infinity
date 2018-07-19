using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Throwables
{
	public class EndlessBombBouncy : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Bouncy Bomb");
            Tooltip.SetDefault("Very bouncy.");
        }

        public override void SetDefaults()
		{
			item.damage = 99;
			item.thrown = true;
			item.width = 22;
			item.height = 22;
			item.useTime = 24;
			item.useAnimation = 24;
			item.useStyle = 1;
            item.UseSound = SoundID.Item1;
            item.maxStack = 1;
			item.consumable = false;
			item.knockBack = 8f;
			item.value = 10;
			item.rare = 4;
			item.shoot = ProjectileID.BouncyBomb;
			item.shootSpeed = 5f;
			item.noMelee = true; //Makes it so it cannot do damage like a sword
			item.noUseGraphic = true; //Makes it so the item can't be seen in hand when used.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BouncyBomb, 199);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}