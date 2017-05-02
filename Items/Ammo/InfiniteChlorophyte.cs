using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class InfiniteChlorophyte : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Endless Chlorophyte Quiver";
			item.damage = 16;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "Still bounces back after hitting a wall, but you don't run out.";
			item.consumable = false;
			item.knockBack = 3.5f;
			item.value = 10;
			item.rare = 2;
			item.shoot = 225;
			item.shootSpeed = 4.5f;
			item.ammo = 40;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1235, 3996);
			recipe.AddTile(125);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}