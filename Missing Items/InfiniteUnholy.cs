using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items
{
	public class InfiniteUnholy : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Endless Unholy Quiver";
			item.damage = 12;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "This isn't a great reward for farming the Eye so much.";
			item.consumable = false;
			item.knockBack = 3f;
			item.value = 10;
			item.rare = 2;
			item.shoot = 4;
			item.shootSpeed = 3.4f;
			item.ammo = 40;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(47, 3996);
			recipe.AddTile(114);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}