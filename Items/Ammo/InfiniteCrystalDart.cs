using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class InfiniteCrystalDart : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Infinite Crystal Dart";
			item.damage = 15;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "Bingo bango bongo!";
			item.consumable = false;
			item.knockBack = 3.5f;
			item.value = 10;
			item.rare = 2;
			item.shoot = 477;
			item.shootSpeed = 1f;
			item.ammo = AmmoID.Dart;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrystalDart, 3996);
			recipe.AddTile(125);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}