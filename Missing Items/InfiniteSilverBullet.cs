using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items
{
	public class InfiniteSilverBullet : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Endless Silver Pouch";
			item.damage = 9;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "Aren't these good for killing alligators?";
			item.consumable = false;
			item.knockBack = 3f;
			item.value = 10;
			item.rare = 2;
			item.shoot = 14;
			item.shootSpeed = 4.5f;
			item.ammo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(278, 3996);
			recipe.AddTile(114);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}