using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items
{
	public class PCoin : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Evershining Platinum Coin";
			item.damage = 200;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "The product of hours of grinding and farming";
			item.consumable = false;
			item.knockBack = 2f;
			item.value = 10;
			item.rare = 2;
			item.shoot = 161;
			item.shootSpeed = 4f;
			item.ammo = AmmoID.Coin;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(74, 999);
			recipe.AddTile(114);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}