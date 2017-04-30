using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items
{
	public class InfiniteLuminite : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Endless Luminite Quiver";
			item.damage = 15;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "Turns enemies into a + bi form.";
			item.consumable = false;
			item.knockBack = 3.5f;
			item.value = 10;
			item.rare = 2;
			item.shoot = 639;
			item.shootSpeed = 3f;
			item.ammo = 40;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3568, 3996);
			recipe.AddTile(125);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}