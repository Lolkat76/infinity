using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items
{
	public class InfiniteFlaming : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Endless Flaming Arrow";
			item.damage = 7;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "Feel the bern.";
			item.consumable = false;
			item.knockBack = 2f;
			item.value = 10;
			item.rare = 2;
			item.shoot = 2;
			item.shootSpeed = 3.5f;
			item.ammo = 40;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(41, 3996);
			recipe.AddTile(114);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}