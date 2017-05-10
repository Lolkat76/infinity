using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items
{
	public class SCoin : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Evershining Silver Coin";
			item.damage = 50;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "It reflects all forms of light";
			item.consumable = false;
			item.knockBack = 2f;
			item.value = 10;
			item.rare = 2;
			item.shoot = 159;
			item.shootSpeed = 2f;
			item.ammo = AmmoID.Coin;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(72, 999);
			recipe.AddTile(114);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}