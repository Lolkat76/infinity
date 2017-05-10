using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items
{
	public class InfiniteRocket3 : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Rocket III Munitions Crate";
			item.damage = 65;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "Contains an endless supply of Rocket IIIs.";
			item.consumable = false;
			item.knockBack = 6f;
			item.value = 10;
			item.rare = 2;
			item.shoot = 6;
			item.shootSpeed = 3f;
			item.ammo = 771;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(773, 3996);
			recipe.AddTile(114);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}