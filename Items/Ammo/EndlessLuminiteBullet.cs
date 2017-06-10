using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class EndlessLuminiteBullet : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Luminite Pouch");
            Tooltip.SetDefault("Line 'em up and knock 'em down... infinitely.");
        }

        public override void SetDefaults()
		{
			item.damage = 22;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.consumable = false;
			item.knockBack = 3f;
			item.value = 10;
			item.rare = 2;
			item.shoot = ProjectileID.MoonlordBullet;
			item.shootSpeed = 2f;
			item.ammo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MoonlordBullet, 3996);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}