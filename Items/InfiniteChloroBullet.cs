using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items
{
	public class InfiniteChloroBullet : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Endless Chlorophyte Pouch";
			item.damage = 10;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "Chases after your enemy... infinitely.";
			item.consumable = false;
			item.knockBack = 4.5f;
			item.value = 10;
			item.rare = 2;
			item.shoot = 207;
			item.shootSpeed = 5f;
			item.ammo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1179, 3996);
			recipe.AddTile(125);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}