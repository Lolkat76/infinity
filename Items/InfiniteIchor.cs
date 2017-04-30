using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items
{
	public class InfiniteIchor : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Endless Ichor Quiver";
			item.damage = 16;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "Decreases taget's defense. Not infinitely though, unlike the amount of arrows.";
			item.consumable = false;
			item.knockBack = 3f;
			item.value = 10;
			item.rare = 2;
			item.shoot = 278;
			item.shootSpeed = 4.25f;
			item.ammo = 40;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1334, 3996);
			recipe.AddTile(125);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}