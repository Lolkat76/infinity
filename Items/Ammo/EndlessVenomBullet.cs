using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class EndlessVenomBullet : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Infinite Venom Bullet");
        }

        public override void SetDefaults()
		{
			item.damage = 14;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.consumable = false;
			item.knockBack = 4.1f;
			item.value = 10;
			item.rare = 2;
			item.shoot = ProjectileID.VenomBullet;
			item.shootSpeed = 5.3f;
			item.ammo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.VenomBullet, 3996);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}