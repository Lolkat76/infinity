using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items
{
	public class InfinitePoisonDart : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Infinite Poison Dart";
			item.damage = 10;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "Click click click.";
			item.consumable = false;
			item.knockBack = 2f;
			item.value = 10;
			item.rare = 2;
			item.shoot = 267;
			item.shootSpeed = 2f;
			item.ammo = AmmoID.Dart;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PoisonDart, 3996);
			recipe.AddTile(125);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}