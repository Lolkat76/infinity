using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items
{
	public class InfiniteIchorBullet : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Endless Ichor Pouch";
			item.damage = 13;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "After nine years in development, hopefully, they will have been worth the wait.";
			item.consumable = false;
			item.knockBack = 4f;
			item.value = 10;
			item.rare = 2;
			item.shoot = 279;
			item.shootSpeed = 5.25f;
			item.ammo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1335, 3996);
			recipe.AddTile(125);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}