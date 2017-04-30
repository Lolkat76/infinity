using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items
{
	public class InfiniteCrystalBullet : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Endless Crystal Pouch";
			item.damage = 9;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "Creates several crystal shards on impact.";
			item.consumable = false;
			item.knockBack = 1f;
			item.value = 10;
			item.rare = 2;
			item.shoot = 89;
			item.shootSpeed = 5f;
			item.ammo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(515, 3996);
			recipe.AddTile(125);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}