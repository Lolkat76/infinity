using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items
{
	public class InfiniteCursedBullet : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Endless Cursed Pouch";
			item.damage = 12;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "Carrying flammable bullets in a pouch is a smart idea.";
			item.consumable = false;
			item.knockBack = 4f;
			item.value = 10;
			item.rare = 2;
			item.shoot = 104;
			item.shootSpeed = 5f;
			item.ammo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(546, 3996);
			recipe.AddTile(125);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}