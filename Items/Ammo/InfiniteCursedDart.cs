using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class InfiniteCursedDart : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Infinite Cursed Dart";
			item.damage = 9;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "Click click click.";
			item.consumable = false;
			item.knockBack = 2.2f;
			item.value = 10;
			item.rare = 2;
			item.shoot = 478;
			item.shootSpeed = 3f;
			item.ammo = AmmoID.Dart;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CursedDart, 3996);
			recipe.AddTile(125);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}